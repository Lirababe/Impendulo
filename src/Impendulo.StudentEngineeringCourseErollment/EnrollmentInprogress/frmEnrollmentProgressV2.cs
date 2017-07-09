using Impendulo.Common.Enum;
using Impendulo.Data;
using Impendulo.Data.Models;
using Impendulo.Development.Students;
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
                                                      .Include("Student")
                                                      .Include("Student.Individual")
                                                      .Include("CurriculumEnquiries")
                                                      .Include("CurriculumCourseEnrollments")
                                                      .Include("CurriculumCourseEnrollments.Schedules")
                                                      //.Include("CurriculumCourseEnrollments.CurriculumCourse")
                                                      .Include("Curriculum")
                                                      .FirstOrDefault<Data.Models.Enrollment>();

                if (CurrentEnrollmentPreRequisiteID != 0)
                {
                    List<CurriculumCourseEnrollment> CurriculumCourseEnrollmentTemp = new List<CurriculumCourseEnrollment>();
                    foreach (CurriculumCourseEnrollment CurriculumCourseEnrollmentObj in CurrentEnrollment.CurriculumCourseEnrollments)
                    {
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
                btnSelectCourses.Enabled = false;
            }
            else
            {
                //check that all PreRequisites are iether exempt or completed.

                //if ()
                //{

                //}
                btnSelectCourses.Enabled = true;
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
                                                .Include("Enrollment")
                                                //.Include("CurriculumCourse")
                                                .Include("CurriculumCourse.Course")
                                                .Include("CurriculumCourse.Curriculum")
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
            this.CurrentEnrollmentPreRequisiteID = 0;
            this.refreshEnrollment();
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
                         where a.CurriculumCourseEnrollmentID == 3
                         select a).ToList<Schedule>().Count > 0)
                    {
                        row.Cells[colInProgressSelectedCourseMustSchedule.Index].Value = "[ Edit Schedule ]";
                    }
                    else
                    {
                        row.Cells[colInProgressSelectedCourseMustSchedule.Index].Value = "[ Schedule Course ]";
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
    }
}
