using Impendulo.Common.Enum;
using Impendulo.Company.Development;
using Impendulo.Company.SearchForCompany.Development;
using Impendulo.Data.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Scheduling.Development.AllCourses
{
    public partial class frmScheduleCurriculumCourseWizard : MetroForm
    {

        public Schedule CurrentScheduleConfiguration { get; set; }

        private DateTime PossibleStartDate { get; set; }

        // private EnumScheduleLocations CurrentSiteSelection { get; set; }
        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }
        /// <summary>
        /// Currently Selected CurriculumCourseEnrollment Object - with the Following collections loaded
        /// 1. -
        /// </summary>
        public CurriculumCourseEnrollment CurrentSelectedCurriculumCourseEnrollment { get; set; }
        //        private Data.Models.Company CurrentlySelectedCompany { get; set; }

        /// <summary>
        /// Course Obj - contains the Linked Facilitators for the course and Venues to select from
        /// </summary>
        private CurriculumCourse CurrentlySelectedCurriculumCourseToSchedule { get; set; }

        public int CurrentPosition { get; set; }
        public frmScheduleCurriculumCourseWizard(DateTime InitialStartDate)
        {
            PossibleStartDate = InitialStartDate;
            InitializeComponent();
            //dtScheduleFromCustomStartDateSelector.Format = DateTimePickerFormat.Custom;
            //dtScheduleFromCustomStartDateSelector.CustomFormat = "MMMM dd, yyyy - dddd";
            dtScheduleFromCustomStartDateSelector.MinDate = PossibleStartDate;
        }

        private void frmScheduleCurriculumCourseWizard_Load(object sender, EventArgs e)
        {
            if (CurrentScheduleConfiguration == null)
            {
                CurrentScheduleConfiguration = new Schedule()
                {
                        
                    ScheduleLocationID = (int)EnumScheduleLocations.Onsite
                };
            }
            if (CurrentEmployeeLoggedIn == null)
            {
                /*
             * Thismust be Commmented out or removed in the production version this is just for Develpoement Testing.
             */
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a).FirstOrDefault<Employee>();
                };

                /***************************************************************************************/
                // MessageBox.Show("It is Required that you be logged in to use the feature.\n Login and try again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();

            }

            //Loads the Wizard
            this.CurrentPosition = 0;
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();

            //pre populates the required information to determine the Available dates
            this.prePopulateCurrentlySelectedCourse();
        }

        #region Pre-Populate Information
        private void prePopulateCurrentlySelectedCourse()
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurrentlySelectedCurriculumCourseToSchedule = CurrentSelectedCurriculumCourseEnrollment.CurriculumCourse;
                Dbconnection.CurriculumCourses.Attach(CurrentlySelectedCurriculumCourseToSchedule);
                //loads the days that can be scheduled.
                if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.CurriculumCourseDayCanBeScheduleds).IsLoaded)
                {
                    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.CurriculumCourseDayCanBeScheduleds).Load();
                }
                //load the course that associated with the Curriculum Course
                if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Reference<Course>(a => a.Course).IsLoaded)
                {
                    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Reference<Course>(a => a.Course).Load();
                }

                //if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.Course.VenueAssociatedCourses).IsLoaded)
                //{
                //    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.Course.VenueAssociatedCourses).Load();
                //}


            };
        }
        #endregion

        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateForwardStep())
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
            if (ValidateBackwardStep())
            {
                if (CurrentPosition - 1 >= 0)
                {
                    CurrentPosition--;
                }
                else
                {

                    //CurrentPosition = 5;
                }
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
        private Boolean ValidateForwardStep()
        {

            Boolean bRtn = true;
            switch (CurrentPosition)
            {
                case 0:
                    //Select On-Site or Off-Site
                    if (CurrentScheduleConfiguration.ScheduleLocationID == (int)EnumScheduleLocations.Onsite)
                    {
                        CurrentPosition++;
                        //CurrentScheduleConfiguration.Companies.Clear();
                    }


                    break;
                case 1:
                    //Select Compnay if Off Site
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
        private Boolean ValidateBackwardStep()
        {

            Boolean bRtn = true;
            switch (CurrentPosition)
            {
                case 0:
                    


                    break;
                case 1:
                    
                    break;
                case 2:
                    //Select Compnay if Off Site
                    if (CurrentScheduleConfiguration.ScheduleLocationID == (int)EnumScheduleLocations.Onsite)
                    {
                        CurrentPosition--;
                        //CurrentScheduleConfiguration.Companies.Clear();
                    }
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
            tbLeadTimeAdjuster.Value = 0;
            txtLeadTimeForSchedulingSearch.Text = tbLeadTimeAdjuster.Value.ToString();
            refreshLeadTimeStartDate(tbLeadTimeAdjuster.Value);
        }
        private void refreshLeadTimeStartDate(int AmountOfDaysToAdd)
        {
            txtLeadTimeStartDate.Text = Common.CustomDateTime.getCustomDateTime(
                CurrentDate: PossibleStartDate,
                AmountDaysToAdd: AmountOfDaysToAdd,
                DaysCanSchedule: GetDayThatCurriculumCourseCanBeScheduled()).ToString("D");
        }
        private List<EnumDayOfWeeks> GetDayThatCurriculumCourseCanBeScheduled()
        {
            List<EnumDayOfWeeks> DaysCanSchedule = new List<EnumDayOfWeeks>();
            //sets the Date One Day Ahead
            foreach (CurriculumCourseDayCanBeScheduled CCDCBS in CurrentSelectedCurriculumCourseEnrollment.CurriculumCourse.CurriculumCourseDayCanBeScheduleds)
            {
                DaysCanSchedule.Add((EnumDayOfWeeks)CCDCBS.DayOfWeekID);
            };
            return DaysCanSchedule;
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

        private void picSelectOnSite_Click(object sender, EventArgs e)
        {
            picSelectOnSite.BackColor = Color.Gainsboro;
            picSelectOffSite.BackColor = Color.Transparent;
            CurrentScheduleConfiguration.ScheduleLocationID = (int)EnumScheduleLocations.Onsite;
            lblCurentlySelectedSiteType.Text = "On-Site";
        }

        private void picSelectOffSite_Click(object sender, EventArgs e)
        {
            picSelectOnSite.BackColor = Color.Transparent;
            picSelectOffSite.BackColor = Color.Gainsboro;
            CurrentScheduleConfiguration.ScheduleLocationID = (int)EnumScheduleLocations.OffSite;
            lblCurentlySelectedSiteType.Text = "Off-Site";
        }
        private void refreshCompanyInfo()
        {
            this.populateCompanyInfo();
        }

        private void populateCompanyInfo()
        {
            //if (CurrentScheduleConfiguration.Companies.Count > 0)
            //{
            //    companyBindingSource.DataSource = (from a in CurrentScheduleConfiguration.Companies
            //                                       select a).ToList<Data.Models.Company>();
            //}
            //else
            //{
            //    companyBindingSource.Clear();
            //}
        }

        private void btnSearchForCompany_Click(object sender, EventArgs e)
        {
            using (frmCompanySearch frm = new frmCompanySearch())
            {
                frm.ShowDialog();
                if (frm.CurrentCompany != null)
                {
                    //this.CurrentScheduleConfiguration..Clear();
                    //this.CurrentScheduleConfiguration.Companies.Add(frm.CurrentCompany);
                }
                else
                {
                    //this.CurrentScheduleConfiguration.Companies.Clear();
                }
            };
            this.refreshCompanyInfo();
        }

        private void btnReviewCompanyDetails_Click(object sender, EventArgs e)
        {
            if (companyBindingSource.Count > 0)
            {
                using (frmCompany frm = new frmCompany())
                {
                    frm.txtCompaniesFilterCriteria.Text = ((Data.Models.Company)companyBindingSource.Current).CompanyName.ToString();
                    frm.ShowDialog();
                    this.refreshCompanyInfo();
                }

            }
        }

        private void tbLeadTimeAdjuster_Scroll(object sender, ScrollEventArgs e)
        {
            txtLeadTimeForSchedulingSearch.Text = e.NewValue.ToString();
            refreshLeadTimeStartDate(e.NewValue);
        }

        private void tableLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
