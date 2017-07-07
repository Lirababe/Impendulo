using Impendulo.Data.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Courses.Development.LinkCurriculumCourseWizard
{
    public partial class frmAddCurriculumCourseV2 : MetroForm
    {

        public int CurrentPosition { get; set; }
        public int CurriculumID { get; set; }

        private CurriculumCourse newCourseObj { get; set; }

        private List<LookupDayOfWeek> AvaiableDays { get; set; }
        private List<CurriculumCourseDayCanBeScheduled> LinkedDays { get; set; }

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }
        public frmAddCurriculumCourseV2()
        {
            this.CurriculumID = 1;
            InitializeComponent();
            AvaiableDays = new List<LookupDayOfWeek>();
            LinkedDays = new List<CurriculumCourseDayCanBeScheduled>();
        }

        private void frmAddCurriculumCourseV2_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {
                /*
             * Thismust be Commmented out or removed in the production version this is just for Develpoement Testing.
             */
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               select a).FirstOrDefault<Employee>();
                };

                /***************************************************************************************/
                // MessageBox.Show("It is Required that you be logged in to use the feature.\n Login and try again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();

            }
            this.refreshAllStaticDropDownLists();
            this.CurrentPosition = 0;
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();

        }


        #region Pre-Populate Stactic Drop Down Lists and Days

        private void populateAvaliableDays()
        {

            using (var Dbconnection = new MCDEntities())
            {
                AvaiableDays = (from a in Dbconnection.LookupDayOfWeeks
                                select a)
                                .ToList<LookupDayOfWeek>();
            };
        }
        private void refreshAllStaticDropDownLists()
        {
            this.populateEnrollmentTypes();
            this.populateDepartments();
            this.populateAvaliableDays();

        }

        private void populateDepartments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupDepartmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                            orderby a.DepartmentName
                                                            select a)
                                                            .Include("Courses")
                                                            .Include("Courses.CurriculumCourses")
                                                            .ToList<LookupDepartment>();
            };
        }
        private void populateCourses()
        {
            if (lookupDepartmentBindingSource.List.Count > 0)
            {
                int _EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue);
                List<Course> AllCourses = (from a in ((LookupDepartment)lookupDepartmentBindingSource.Current).Courses
                                           select a).Except(from a in ((LookupDepartment)lookupDepartmentBindingSource.Current).Courses
                                                            from b in a.CurriculumCourses
                                                            where b.CurriculumID == this.CurriculumID
                                                            && b.EnrollmentTypeID == _EnrollmentTypeID
                                                            select a).ToList<Course>();

                courseBindingSource.DataSource = (from a in AllCourses
                                                  orderby a.CourseName ascending
                                                  where a.CourseName.ToLower().Contains(txtCourseNameFilter.Text.ToLower())
                                                  select a).ToList<Course>();
            }



        }
        private void populateEnrollmentTypes()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupEnrollmentTypeBindingSource.DataSource = (from a in Dbconnection.LookupEnrollmentTypes
                                                                select a).ToList<LookupEnrollmentType>();
            };
        }
        #endregion

        #region Rehesh Methods

        private void RefreshAvailalbleDays()
        {
            this.populateAvaiabledays();
        }
        private void refreshLkinkedDays()
        {
            this.populateLinkedDays();
        }
        #endregion

        #region Populate Methods

        private void populateAvaiabledays()
        {
            //using (var Dbconnection = new MCDEntities())
            //{
            //    availableCurriculumCourseDayCanBeScheduledBindingSource.DataSource = (from a in Dbconnection.LookupDayOfWeeks
            //                                                                          select a).Except(from a in Dbconnection.CurriculumCourseDayCanBeScheduleds
            //                                                                                           where a.CurriculumCourseID == 0
            //                                                                                           where a.LookupDayOfWeek)
            //};
        }
        private void populateLinkedDays()
        {
            linkedCcurriculumCourseDayCanBeScheduledBindingSource.DataSource = (from a in LinkedDays
                                                                                select a).ToList<CurriculumCourseDayCanBeScheduled>();
        }
        #endregion
        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (CurrentPosition + 1 < MainflowLayoutPanel.Controls.Count)
                {
                    //if step validation is passed the next window is display by incrementing the CurrentPosition Counter.
                    CurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are Details Correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        //this.mustSaveItems = true;
                        this.Close();
                    }
                }
                this.setCenterDisplayPanels();
                this.setNavigationControls();
                this.loadupStep();
            }
        }
        private void navigateBackwards()
        {
            if (CurrentPosition - 1 >= 0)
            {
                CurrentPosition--;
            }
            else
            {

                //CurrentPosition = 5;
            }
            //Hide All Panels inside the MainFlowPanel
            //MainflowLayoutPanel
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }


        private void setNavigationControls()
        {
            if (CurrentPosition == 0)
            {
                btnPreviousSection.Visible = false;
                btnNextSection.Text = "Next";
            }
            else
            {
                if (CurrentPosition == MainflowLayoutPanel.Controls.Count - 1)
                {
                    btnNextSection.Text = "Save";

                }
                else
                {
                    btnNextSection.Text = "Next";

                }
                btnPreviousSection.Visible = true;
            }
            int iAmountOfSteps = 0;
            foreach (var Control in tableLayoutPanel5.Controls)
            {
                if (Control is Label)
                {
                    iAmountOfSteps++;
                    //NavigationPanel
                    var lblObj = (Label)Control;
                    if (Convert.ToInt32(lblObj.Tag.ToString()) == CurrentPosition)
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold);
                        lblObj.Margin = new Padding(6, 7, 3, 3);
                    }
                    else
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Regular);
                        lblObj.Margin = new Padding(3, 7, 3, 3);
                    }
                }
            }
            double dblPercentageComplete = (((Convert.ToDouble(CurrentPosition + 1) / Convert.ToDouble(iAmountOfSteps))) * 100);
            wizardStepProgressBar.Value = Convert.ToInt32(dblPercentageComplete);

        }
        private void setCenterDisplayPanels()
        {
            foreach (Control gbControl in MainflowLayoutPanel.Controls)
            {
                if (gbControl is GroupBox)
                {
                    var gbObj = (GroupBox)gbControl;
                    gbObj.Hide();
                }
            }
            foreach (Control Control in MainflowLayoutPanel.Controls)
            {
                if (Control is GroupBox)
                {
                    var gbObj = (GroupBox)Control;
                    if (Convert.ToInt32(gbObj.Tag.ToString()) == CurrentPosition)
                    {
                        gbObj.Show();
                        gbObj.Width = MainflowLayoutPanel.Width;
                        gbObj.Height = MainflowLayoutPanel.Height;
                    }
                    else
                    {
                        gbObj.Hide();
                        gbObj.Width = 0;
                        gbObj.Height = 0;
                    }
                }
            }
        }
        #endregion

        #region Wizard Methods
        private void loadupStep()
        {
            switch (CurrentPosition)
            {
                case 0:
                    //Student Details
                    this.loadupStepOne();
                    break;
                case 1:
                    this.loadupStepTwo();
                    break;
                case 2:
                    this.loadupStepThree();
                    break;
                case 3:
                    this.loadupStepFour();
                    break;
                case 4:
                    this.loadupStepFive();
                    break;
                case 5:
                    this.loadupStepSix();
                    break;
                case 6:
                    this.loadupStepSeven();
                    break;
                case 7:
                    this.loadupStepEight();
                    break;
                default:

                    break;
            }

        }
        private void btnPreviousSection_Click(object sender, EventArgs e)
        {
            navigateBackwards();
        }

        private void btnNextSection_Click(object sender, EventArgs e)
        {
            navigateForward();
        }
        private Boolean ValidateStep()
        {

            Boolean bRtn = true;
            switch (CurrentPosition)
            {
                case 0:
                    break;
                case 1:
                    using (var Dbconnection = new MCDEntities())
                    {
                        using (System.Data.Entity.DbContextTransaction dbTran = Dbconnection.Database.BeginTransaction())
                        {
                            try
                            {
                                //CRUD Operations
                                Course CourseObj = (Course)courseBindingSource.Current;
                                decimal Cost = 0;
                                decimal Cents = 0;
                                decimal TotalCost = 0;
                                if (txtCourseCost.Text.Replace("R", "").Length > 0)
                                {
                                    Cost = Convert.ToDecimal(txtCourseCost.Text.Replace("R", ""));
                                }

                                if (txtCourseCostCents.Text.Length > 0)
                                {
                                    Cents = (Convert.ToDecimal(txtCourseCostCents.Text)) / 100;
                                }
                                TotalCost = Cost + Cents;


                                if (newCourseObj == null)
                                {
                                    newCourseObj = new CurriculumCourse
                                    {
                                        CourseID = CourseObj.CourseID,
                                        CurriculumID = this.CurriculumID,
                                        EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue),
                                        Cost = TotalCost,
                                        Duration = Convert.ToInt32(nudCourseDuration.Value),
                                        CurricullumCourseCode = new CurricullumCourseCode
                                        {
                                            CurricullumCourseCodeValue = txtCourseCourseCode.Text
                                        },
                                        CurriculumCourseMinimumMaximum = new CurriculumCourseMinimumMaximum
                                        {
                                            CurriculumCourseMaximum = Convert.ToInt32(nudCourseMaximumAllowed.Value),
                                            CurriculumCourseMinimum = Convert.ToInt32(nudCourseMinimumAllowed.Value)
                                        }
                                    };
                                }
                                else
                                {
                                    newCourseObj.CourseID = CourseObj.CourseID;
                                    newCourseObj.EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue);
                                    newCourseObj.Cost = TotalCost;
                                    newCourseObj.Duration = Convert.ToInt32(nudCourseDuration.Value);
                                    newCourseObj.CurricullumCourseCode.CurricullumCourseCodeValue = txtCourseCourseCode.Text;
                                    newCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMaximum = Convert.ToInt32(nudCourseMaximumAllowed.Value);
                                    newCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMinimum = Convert.ToInt32(nudCourseMinimumAllowed.Value);
                                    Dbconnection.Entry(newCourseObj).State = EntityState.Modified;
                                }

                                Dbconnection.CurriculumCourses.Add(newCourseObj);

                                ////saves all above operations within one transaction
                                Dbconnection.SaveChanges();

                                //commit transaction
                                dbTran.Commit();
                            }
                            catch (Exception ex)
                            {
                                if (ex is DbEntityValidationException)
                                {
                                    foreach (DbEntityValidationResult entityErr in ((DbEntityValidationException)ex).EntityValidationErrors)
                                    {
                                        foreach (DbValidationError error in entityErr.ValidationErrors)
                                        {
                                            MessageBox.Show(error.ErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                //Rollback transaction if exception occurs
                                dbTran.Rollback();

                                bRtn = false;
                            }
                        }
                    };
                    break;
                case 2:

                    break;
                case 3:


                    break;

                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;

                default:
                    bRtn = false;
                    break;
            }

            return bRtn;
        }

        #region "Each Wizard Page Loadup"
        private void loadupStepOne()
        {


        }

        private void loadupStepTwo()
        {

        }

        private void loadupStepThree()
        {

            this.RefreshAvailalbleDays();
            this.refreshLkinkedDays();

        }


        private void loadupStepFour()
        {

        }
        private void loadupStepFive()
        {

        }
        private void loadupStepSix()
        {

        }
        private void loadupStepSeven()
        {

        }
        private void loadupStepEight()
        {

        }



        #endregion

        #endregion

        #endregion

        private void lookupDepartmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.populateCourses();
        }

        private void btnFilterCourses_Click(object sender, EventArgs e)
        {
            this.populateCourses();
        }

        private void btnRefreshCourseFilter_Click(object sender, EventArgs e)
        {
            this.txtCourseNameFilter.Text = "";
            this.populateCourses();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            LookupDepartment CurrentDepartment = (LookupDepartment)lookupDepartmentBindingSource.Current;
            int AmountCouresesTheSame = (from a in CurrentDepartment.Courses
                                         where a.CourseName.ToLower().Contains(txtNewCourse.Text.ToLower())
                                         select a).Count<Course>();
            if (AmountCouresesTheSame == 0)
            {
                try
                {
                    using (var Dbconnection = new MCDEntities())
                    {

                        Course newCourse = new Course()
                        {
                            DepartmentID = Convert.ToInt32(cboDepartment.SelectedValue),
                            CourseName = txtNewCourse.Text,
                            CourseDescription = txtNewCourseDescription.Text
                        };
                        Dbconnection.Courses.Add(newCourse);
                        Dbconnection.SaveChanges();

                        CurrentDepartment.Courses.Add(newCourse);
                        this.populateCourses();
                    };
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show(error.ErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show(dbEx.Message);
                }
            }
            else
            {
                MessageBox.Show(txtNewCourse.Text + " - Already Exisits For this Department.", "Add Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lookupEnrollmentTypeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.populateCourses();
        }

        private void cboEnrollmentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            splitContainerAddNewCourse.Panel2Collapsed = false;
            splitContainerAddNewCourse.Panel1Collapsed = true;
        }

        private void btnCancelAddingCourse_Click(object sender, EventArgs e)
        {
            splitContainerAddNewCourse.Panel2Collapsed = true;
            splitContainerAddNewCourse.Panel1Collapsed = false;
        }

        private void dgcAvaiableDays_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumCourseDayCanBeScheduledObj = (CurriculumCourseDayCanBeScheduled)(row.DataBoundItem);


                    //row.Cells[colAvailableDays.Index].Value = CurriculumCourseDayCanBeScheduledObj.LookupDayOfWeek.DayOfWeek.ToString();

                }
            }
        }
    }
}
