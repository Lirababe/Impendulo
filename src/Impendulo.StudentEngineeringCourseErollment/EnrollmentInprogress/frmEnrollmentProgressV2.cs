using Impendulo.Common.Enum;
using Impendulo.Data.Models;
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
        public int CurrentEquiryID { get; set; }
        private Enrollment CurrentEnrollment { get; set; }

        private List<CurriculumCourseEnrollment> AllPreRequisiteEnrollments;
        public frmEnrollmentInProgressV2()
        {
            AllPreRequisiteEnrollments = new List<CurriculumCourseEnrollment>();
            CurrentEnrollmentPreRequisiteID = 0;
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
                                                      //.Include("CurriculumCourseEnrollments.CurriculumCourse")
                                                      .Include("Curriculum")
                                                      .FirstOrDefault<Data.Models.Enrollment>();
               
                
                enrollmentBindingSourceMain.DataSource = CurrentEnrollment;
                
            };
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

                    if (!(CurriculumCourseEnrollmentObj.Excempt))
                    {
                        row.Cells[colPreRequisiteCourseProcessPreRequisiteCourse.Index].Value = "[ Process ]";
                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Value = "[ Exempt Course ]";
                    }
                    else
                    {
                        row.Cells[colPreRequisiteCourseProcessPreRequisiteCourse.Index].Value = "";
                        row.Cells[colPreRequisiteCourseExemmptionStatus.Index].Value = "[ Re-Instate Course ]";
                    }
                    row.Cells[colPreRequisiteCourseCurriculumName.Index].Value = CurriculumCourseEnrollmentObj.CurriculumCourse.Curriculum.CurriculumName.ToString();
                    row.Cells[colPreRequisiteCourseName.Index].Value = CurriculumCourseEnrollmentObj.CurriculumCourse.Course.CourseName.ToString();

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
            Enrollment PreRequisiteEnrollment = ((CurriculumCourseEnrollment)curriculumCourseEnrollmentPreRequisiteCourseBindingSource.Current).Enrollment;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.CurrentEnrollmentPreRequisiteID = PreRequisiteEnrollment.EnrollmentID;
                    this.refreshEnrollment();
                    break;
            }
        }

        private void btnSwitchBackToParentEnrollment_Click(object sender, EventArgs e)
        {
            this.CurrentEnrollmentPreRequisiteID = 0;
            this.refreshEnrollment();
        }
    }
}
