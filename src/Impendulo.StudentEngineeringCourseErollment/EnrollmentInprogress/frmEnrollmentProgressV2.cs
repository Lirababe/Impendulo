using Impendulo.Common.Enum;
using Impendulo.Data;
using Impendulo.Data.Models;
using Impendulo.Development.Students;
using Impendulo.Scheduling.Development.AllCourses;
using Impendulo.StudentEngineeringCourseErollment.Development.EnrollmentException;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentCourseSelection;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress
{
    public partial class frmEnrollmentInProgressV2 : MetroForm
    {

        /*Diff Modes that the form can be loaded
         1. Listed by current Enquiry - which list all enrollments for the the specific enquiry
         2. Lists by current Equiry and Enrollment which lists only current enrollemnt associated with the a specific enquiry
         3. All Enrollments (First 50)
         4. Enrolment filter by search page.
         */
        private Boolean IsLoadingPreRequisiteEnrollment = false;
        public EnumDepartments CurrentSelectedDepartment { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }
        public int CurrentEnrollmentID { get; set; }
        private int CurrentEnrollmentPreRequisiteID { get; set; }

        private int CurrentCurriculumCourseEnrollmentID { get; set; }
        public int CurrentEquiryID { get; set; }
        private Enrollment CurrentEnrollment { get; set; }

        private List<CurriculumCourseEnrollment> AllPreRequisiteEnrollments;
        public frmEnrollmentInProgressV2()
        {
            AllPreRequisiteEnrollments = new List<CurriculumCourseEnrollment>();
            CurrentEnrollmentPreRequisiteID = 0;
            CurrentCurriculumCourseEnrollmentID = 0;
            InitializeComponent();
        }

        private void frmEnrollmentInProgressV2_Load(object sender, EventArgs e)
        {
            //loadup Doucment Types
            refreshEnrollmentDocumentTypes();
            //Load up Current Enrollment
            refreshEnrollment();

            showAddCourseForEnrollment();
        }

        private void showAddCourseForEnrollment()
        {
            splitContainerAddAndRevertCourse.Panel1Collapsed = false;
            splitContainerAddAndRevertCourse.Panel2Collapsed = true;
        }

        private void hideAddCourseForEnrollment()
        {
            splitContainerAddAndRevertCourse.Panel1Collapsed = true;
            splitContainerAddAndRevertCourse.Panel2Collapsed = false;
        }

        #region Resfresh Methods
        private void refreshEnrollmentDocumentTypes()
        {
            this.populateEnrollmentDocumentTypes();
        }
        private void refreshEnrollment()
        {
            this.populateEnrollment();

        }
        private void refershEnrollmentPreRequisites()
        {
            this.populateEnrollmentPreRequisites();
        }
        #endregion

        #region Populate Methods

        private void populateEnrollmentDocumentTypes()
        {
            using (var Dbconnection = new MCDEntities())
            {
                lookupEnrollentDocumentTypeBindingSource.DataSource = (from a in Dbconnection.LookupEnrollentDocumentTypes
                                                                       select a).ToList<LookupEnrollentDocumentType>();
            };

        }
        private void populateEnrollment()
        {
            int EnrollmentToLoadID = 0;
            using (var Dbconnection = new MCDEntities())
            {
                //Load PreRequisteEnrollment
                if (CurrentEnrollmentPreRequisiteID != 0)
                {
                    EnrollmentToLoadID = this.CurrentEnrollmentPreRequisiteID;
                }
                else//Load Enrollment
                {
                    EnrollmentToLoadID = this.CurrentEnrollmentID;
                }
                CurrentEnrollment = (from a in Dbconnection.Enrollments
                                     where a.EnrollmentID == EnrollmentToLoadID
                                     select a)
                                     .Include(a => a.Student)
                                     .Include(a => a.Student.Individual)
                                     .Include(a => a.CurriculumEnquiries)
                                     .Include(a => a.CurriculumCourseEnrollments)
                                     .Include(a => a.CurriculumCourseEnrollments.Select(b => b.Schedules))
                                     .Include(a => a.CurriculumCourseEnrollments.Select(b => b.CurriculumCourse))
                                     .Include(a => a.Curriculum)
                                        .FirstOrDefault<Data.Models.Enrollment>();

                if (CurrentEnrollmentPreRequisiteID != 0)
                {

                    List<CurriculumCourseEnrollment> CurriculumCourseEnrollmentTemp = new List<CurriculumCourseEnrollment>();
                    foreach (CurriculumCourseEnrollment CurriculumCourseEnrollmentObj in CurrentEnrollment.CurriculumCourseEnrollments)
                    {
                        //             //trying code
                        //             CurrentEnrollment.CurriculumCourseEnrollments.Clear();
                        //             Dbconnection.Entry(blog)
                        //.Collection("Posts")
                        //.Query()
                        //.Where(p => p.Tags.Contains("entity-framework")
                        //.Load();
                        //             //end trying code

                        if (CurriculumCourseEnrollmentObj.CurriculumCourseEnrollmentID == this.CurrentCurriculumCourseEnrollmentID)
                        {
                            CurriculumCourseEnrollmentTemp.Add(CurriculumCourseEnrollmentObj);
                        }
                    }
                    CurrentEnrollment.CurriculumCourseEnrollments.Clear();
                    foreach (CurriculumCourseEnrollment CurriculumCourseEnrollmentObj in CurriculumCourseEnrollmentTemp)
                    {
                        CurrentEnrollment.CurriculumCourseEnrollments.Add(CurriculumCourseEnrollmentObj);
                    }

                    //SetControls

                }
                else
                {

                }

                enrollmentBindingSourceMain.DataSource = CurrentEnrollment;

            };
        }
        private void setControls()
        {
            if (CurrentEnrollmentPreRequisiteID != 0)
            {
                //btnSelectCourses.Enabled = false;
            }
            else
            {
                //check that all PreRequisites are iether exempt or completed.

                //if ()
                //{

                //}
                // btnSelectCourses.Enabled = true;
            }
        }
        private void populateEnrollmentPreRequisites()
        {
            int EnrollmentToLoadID = 0;
            using (var Dbconnection = new MCDEntities())
            {
                //Load PreRequisteEnrollment
                if (CurrentEnrollmentPreRequisiteID != 0)
                {
                    EnrollmentToLoadID = this.CurrentEnrollmentPreRequisiteID;
                }
                else//Load Enrollment
                {
                    EnrollmentToLoadID = this.CurrentEnrollmentID;
                }
                AllPreRequisiteEnrollments = (from a in Dbconnection.CurriculumCourseEnrollments
                                                  //from b in a.CurriculumCourse.Curriculum

                                                  //from b in a.CurriculumCourseEnrollments
                                                  //from c in b.CurriculumCourse.Course
                                              where a.Enrollment.EnrolmentParentID == EnrollmentToLoadID
                                              select a)
                                                .Include(a => a.Enrollment)
                                                .Include(a => a.CurriculumCourse)
                                                .Include(a => a.CurriculumCourse.Course)
                                                .Include(a => a.CurriculumCourse.Curriculum)
                                                .Include(a => a.LookupEnrollmentProgressState)
                                                .ToList<CurriculumCourseEnrollment>();
            };


            curriculumCourseEnrollmentPreRequisiteCourseBindingSource.DataSource = AllPreRequisiteEnrollments;
        }

        #endregion

        #region Controls Event Methods

        #endregion



        private void enrollmentBindingSourceMain_DataSourceChanged(object sender, EventArgs e)
        {
            refershEnrollmentPreRequisites();
        }

        private void dgvEnrollmentPreRequisites_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourseEnrollment CurriculumCourseEnrollmentObj = (CurriculumCourseEnrollment)row.DataBoundItem;

                    if (!(CurriculumCourseEnrollmentObj.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.Excempt))
                    {
                        row.Cells[colPreRequisiteCourseProcessPreRequisiteCourse.Index].Value = "[ Edit ]";

                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Value = "[ Exempt Course ]";
                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Tag = 0;
                    }
                    else
                    {
                        row.Cells[colPreRequisiteCourseProcessPreRequisiteCourse.Index].Value = "";
                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Value = "[ Re-Instate ]";
                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Tag = 1;
                    }
                    row.Cells[colPreRequisiteCourseCurriculumName.Index].Value = CurriculumCourseEnrollmentObj.CurriculumCourse.Curriculum.CurriculumName.ToString();
                    row.Cells[colPreRequisiteCourseName.Index].Value = CurriculumCourseEnrollmentObj.CurriculumCourse.Course.CourseName.ToString();
                    row.Cells[colPreRequisiteCourseStatus.Index].Value = CurriculumCourseEnrollmentObj.LookupEnrollmentProgressState.EnrollmentProgressCurrentState.ToString();
                    //
                    //CurriculumCourse CurriculumCourseObj = (from a in EnrollmentObj.CurriculumCourseEnrollments
                    //                                        where a.CurriculumCourse.CurriculumID == EnrollmentObj.CurriculumID
                    //                                        select a.CurriculumCourse)
                    //                                        .FirstOrDefault<CurriculumCourse>();
                    //row.Cells[colApprenticeshipPreRequisiteCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                    //row.Cells[colApprenticeshipPrerequisteProcessingStatus.Index].Value = EnrollmentObj.LookupEnrollmentProgressState.EnrollmentProgressCurrentState.ToString();
                }
            }
        }



        private void dgvEnrollmentPreRequisites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Enrollment PreRequisiteEnrollment = ((CurriculumCourseEnrollment)curriculumCourseEnrollmentPreRequisiteCourseBindingSource.Current).Enrollment;
            CurriculumCourseEnrollment CurriculumCourseEnrollmentObj = ((CurriculumCourseEnrollment)curriculumCourseEnrollmentPreRequisiteCourseBindingSource.Current);

            switch (e.ColumnIndex)
            {
                case 3:
                    this.CurrentEnrollmentPreRequisiteID = CurriculumCourseEnrollmentObj.Enrollment.EnrollmentID;
                    this.CurrentCurriculumCourseEnrollmentID = CurriculumCourseEnrollmentObj.CurriculumCourseEnrollmentID;
                    this.refreshEnrollment();
                    this.hideAddCourseForEnrollment();
                    break;
                case 4:
                    if (Convert.ToInt32(dgvEnrollmentPreRequisites.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag) == 0)
                    {
                        using (frmEnrollmentException frm = new frmEnrollmentException())
                        {
                            frm.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;
                            frm.EnquiryID = CurrentEquiryID;
                            frm.SelectedCurriculumCourseEnrollment = (CurriculumCourseEnrollment)curriculumCourseEnrollmentPreRequisiteCourseBindingSource.Current;
                            frm.ShowDialog();
                        }
                    }
                    else
                    {

                    }

                    refreshEnrollment();
                    break;
            }
        }

        private void btnSwitchBackToParentEnrollment_Click(object sender, EventArgs e)
        {
            if (CheckIfAllPreRequisitieCoursesAreCompleted())
            {
                using (frmEnrollmentCourseSelection frm = new frmEnrollmentCourseSelection())
                {
                    frm.CurrentEnrollemnt = this.CurrentEnrollment;
                    frm.ShowDialog();
                    refreshEnrollment();
                }
            }
        }

        private Boolean CheckIfAllPreRequisitieCoursesAreCompleted()
        {
            Boolean Rtn = true;
            foreach (CurriculumCourseEnrollment CCE in curriculumCourseEnrollmentPreRequisiteCourseBindingSource.List)
            {
                if (CCE.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress || CCE.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.New_Enrollment)
                {
                    MessageBox.Show(CCE.CurriculumCourse.Curriculum.CurriculumName + " - " + CCE.CurriculumCourse.Course.CourseName + " Is Incomplete - Schedule and process the course first once completed, proceed to configure the courses for the enrollment.", "Process Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return Rtn;

        }
        private void dgvEnrollmentCourseMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourseEnrollment CurriculumCourseEnrollmentObj = (CurriculumCourseEnrollment)row.DataBoundItem;
                    ObservableListSource<Schedule> Schedules = (ObservableListSource<Schedule>)CurriculumCourseEnrollmentObj.Schedules;

                    row.Cells[colCourseEnrollmentMainCourseName.Index].Value = CurriculumCourseEnrollmentObj.CurriculumCourse.Course.CourseName.ToString();

                    if ((from a in Schedules
                         where a.CurriculumCourseEnrollmentID == CurriculumCourseEnrollmentObj.CurriculumCourseEnrollmentID
                         select a).ToList<Schedule>().Count > 0)
                    {
                        Schedule ScheduleObj = (from a in Schedules
                                                where a.CurriculumCourseEnrollmentID == CurriculumCourseEnrollmentObj.CurriculumCourseEnrollmentID
                                                select a).FirstOrDefault<Schedule>();

                        row.Cells[colInProgressSelectedCourseMustSchedule.Index].Value = "[ View Schedule ]";
                        row.Cells[colSelectedEnrollemntStartDate.Index].Value = ScheduleObj.ScheduleStartDate.ToString("D");
                        row.Cells[colSelectedEnrollemntEndDate.Index].Value = ScheduleObj.ScheduleCompletionDate.ToString("D");
                    }
                    else
                    {
                        row.Cells[colInProgressSelectedCourseMustSchedule.Index].Value = "[ Schedule Course ]";
                        row.Cells[colSelectedEnrollemntStartDate.Index].Value = "Not Yet Scheduled";
                        row.Cells[colSelectedEnrollemntEndDate.Index].Value = "Not Yet Scheduled";
                    }


                }
            }

        }

        private void btnSelectCourses_Click(object sender, EventArgs e)
        {
            using (frmEnrollmentCourseSelection frm = new frmEnrollmentCourseSelection())
            {
                frm.CurrentEnrollemnt = this.CurrentEnrollment;
                frm.ShowDialog();
                refreshEnrollment();
            }
        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            using (frmStudentAddUpdate frm = new frmStudentAddUpdate())
            {
                frm.CurrentStudentID = CurrentEnrollment.Student.StudentID;
                frm.ShowDialog();
            }
        }

        private void btnBackToMaunEnrollmentTop_Click(object sender, EventArgs e)
        {
            this.CurrentEnrollmentPreRequisiteID = 0;
            this.refreshEnrollment();
        }

        private void dgvEnrollmentCourseMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CurriculumCourseEnrollment CurrentSelectedCurriculumCourseEnrollment = (CurriculumCourseEnrollment)curriculumCourseEnrollmentsMainCoursesBindingSource.Current;

            switch (e.ColumnIndex)
            {

                case 0:
                    //If if selected Course does not have a Parent Course then it can be scheduled any time forward from today
                    if (CurrentSelectedCurriculumCourseEnrollment.CurriculumCourse.CurriculumCourseParentID == 0)
                    {
                        //TODO: Open Scheduling Form - Pass Currently Selected CurriculumCourseEnrollment Object.
                        using (frmScheduleCurriculumCourseWizard frm = new frmScheduleCurriculumCourseWizard())
                        {
                            frm.CurrentSelectedCurriculumCourseEnrollment = CurrentSelectedCurriculumCourseEnrollment;

                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        /*Has PreRequisite Course*/
                        //Step 1
                        //Determine if all PreRequisite Courses have been Scheduled.
                        if (DetermineIfAllPreRequisiteCourseHaveBeenScheduled(
                            _CurriculumCourseID: CurrentSelectedCurriculumCourseEnrollment.CurriculumCourse.CurriculumCourseID,
                            _EnrollmentID: CurrentSelectedCurriculumCourseEnrollment.EnrollmentID))
                        {
                            //IF All Course Pre-Requiesties Are Scheduled then:
                            //TODO: Open Scheduling Form - Pass the Selected Currc=iculum CourseEnrollment Object

                        }
                    }
                    break;
            }
        }

        private Boolean DetermineIfAllPreRequisiteCourseHaveBeenScheduled(int _CurriculumCourseID, int _EnrollmentID)
        {
            Boolean Rtn = true;
            IEnumerable<CurriculumCourse> PreRequisiteCoursesNotScheduled;
            using (var Dbconnection = new MCDEntities())
            {
                PreRequisiteCoursesNotScheduled = (from a in Dbconnection.GetCurriculumCoursePreRequisiteCourseNotYetScheduled(_CurriculumCourseID, _EnrollmentID)
                                                   select a)
                                                  .ToList<CurriculumCourse>();

                if (PreRequisiteCoursesNotScheduled.Count<CurriculumCourse>() > 0)
                {
                    int iCounter = 1;
                    Rtn = false;
                    String ErrorMessage = "Before proceeding to schedule this course please schedule the following course first, as these are Pre-Requisite Courses for the currently selected course:\n\n";
                    foreach (CurriculumCourse CC in PreRequisiteCoursesNotScheduled)
                    {
                        Dbconnection.Entry(CC).Reference(a => a.Course).Load();
                        ErrorMessage += iCounter + " - " + CC.Course.CourseName + "\n";
                        iCounter++;
                    }
                    MessageBox.Show(ErrorMessage, "Pre-Requisite Course To Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            };


            return Rtn;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRevertBackToMainEnrollment_Click(object sender, EventArgs e)
        {
            this.CurrentEnrollmentPreRequisiteID = 0;
            this.showAddCourseForEnrollment();
            this.refreshEnrollment();
        }
    }
}
