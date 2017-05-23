using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using Impendulo.Common.Enum;
using Impendulo.Common.ProjectionQueryConverter;
using System.Reflection;
using Impendulo.Scheduling.Development.Courses.Apprenticeship;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentCourseSelection;
using Impendulo.Email.Development;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentException;
using Impendulo.Common.FileHandeling;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    public partial class frmStudentCourseEnrollmentV2 : Form
    {
        public frmStudentCourseEnrollmentV2()
        {
            InitializeComponent();
        }

        public Employee CurrentEmployeeLoggedIn { get; set; }

        private void frmStudentCourseEnrollmentV2_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a).FirstOrDefault<Employee>();
                };
            }
            tabEnrollmentWorkbench.SelectedIndex = 1;
            refreshApprenticeship();
        }

        #region Common Functions

        private void populateApprenticeshipDocumnetTypes(EnumDepartments _EnrollmentType)
        {
            if (_EnrollmentType == EnumDepartments.Apprenticeship)
            {
                flowLayoutPanelApprenticeshipDocumentTypes.Controls.Clear();

            }
            using (var Dbconnection = new MCDEntities())
            {
                List<LookupEnrollentDocumentType> cnoType = (from a in Dbconnection.LookupEnrollentDocumentTypes
                                                             select a).ToList<LookupEnrollentDocumentType>();
                Boolean IsFirst = true;
                foreach (LookupEnrollentDocumentType Enrolltype in cnoType)
                {
                    RadioButton radObj = new RadioButton();
                    radObj.Appearance = Appearance.Button;
                    radObj.Text = Enrolltype.EnrollentDocumentType;
                    if (IsFirst)
                    {
                        populateApprenticeshipEnrollmentDocuments(Enrolltype.LookupEnrollentDocumentTypeID);
                        radObj.Checked = true;
                        IsFirst = false;

                    };
                    radObj.Tag = Enrolltype.LookupEnrollentDocumentTypeID;
                    radObj.CheckedChanged += RadObj_ApprenticeshipDocuments_CheckedChanged;
                    if (_EnrollmentType == EnumDepartments.Apprenticeship)
                    {
                        flowLayoutPanelApprenticeshipDocumentTypes.Controls.Add(radObj);
                    }
                }

            };


        }
        private void populateApprenticeshipEnrollmentDocuments(int _EnrollentDocumentTypeID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                Enrollment Enroll = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current));
                fileBindingSource.DataSource = (from a in Dbconnection.ApprenticeshipEnrollmentDocuments
                                                where a.EnrollmentID == Enroll.EnrollmentID
                                                    && a.LookupEnrollentDocumentTypeID == _EnrollentDocumentTypeID
                                                select new
                                                {
                                                    ImageID = a.File.ImageID,
                                                    FileName = a.File.FileName + "." + a.File.FileExtension,
                                                    DateCreated = a.File.DateCreated
                                                }).ToList();

            };
        }
        private void RadObj_ApprenticeshipDocuments_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radObj = (RadioButton)sender;
            populateApprenticeshipEnrollmentDocuments((int)radObj.Tag);
        }
        #endregion
        #region Apprenticeship

        #region Refresh Methods

        private void refreshApprenticeship()
        {
            populateApprienticeship();
        }
        private void refreshApprenticeshipCoursePreRequisites()
        {
            populateApprenticeshipCoursePreRequisites();
        }


        private void refreshApprenticeshipEnrollmentLinkedCourses()
        {
            int _EnrollmentID = 0;
            if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
            {
                _EnrollmentID = ((Enrollment)(apprenticeshipEnrollmentBindingSource.Current)).EnrollmentID;
            }
            populateApprienticeshipLinkedCourse(_EnrollmentID);
        }

        #endregion

        #region Populate methods
        private void clearDataBindingSources()
        {
            apprenticeshipEnrollmentBindingSource.Clear();
        }
        private void populateApprienticeship()
        {

            this.clearDataBindingSources();
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipEnrollmentBindingSource.DataSource =
                    (from a in Dbconnection.Enrollments
                     from b in a.CurriculumEnquiries

                     where
                         // lists the main Enrollemnt Query for the Apprenticeship
                         a.EnrolmentParentID == 0 &&
                         //Only List Emrollment that are not yet Completed(Scheduled).
                         a.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress &&
                         //Lists all Enrollemt that from part of the Apprenticeship Department
                         a.Curriculum.DepartmentID == (int)EnumDepartments.Apprenticeship &&
                         //The enquiry is not closed - means that the client has not cancelled the Enrollment or enquiry.
                         b.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                     orderby b.EnquiryID descending, a.DateIntitiated descending
                     select a).Include("Student")
                     .Include("Student.Individual")
                        .Include("Student.Individual.LookupTitle")
                        .Include("CurriculumEnquiries")
                        .Include("CurriculumCourseEnrollments")
                        .Take<Enrollment>(50)
                        .ToList<Enrollment>();

            };
        }
        private void populateApprenticeshipCoursePreRequisites()
        {
            Enrollment EnrollObj = (Enrollment)apprenticeshipEnrollmentBindingSource.Current;
            if (EnrollObj != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    apprenticeshipPreRequisteCurriculumCourseBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                                                         from b in a.CurriculumCourseEnrollments
                                                                                         where a.EnrolmentParentID == EnrollObj.EnrollmentID
                                                                                         select a)
                                                                                                .Include("CurriculumCourseEnrollments")
                                                                                                //.Include("Curriculum.CurriculumCourses")
                                                                                                //.Include("Curriculum.CurriculumCourses.Course")
                                                                                                .ToList<Enrollment>();
                };
            }
            else
            {
                apprenticeshipPreRequisteCurriculumCourseBindingSource.Clear();
            }


        }

        private void populateAprientceshipAvailableCourses(int _EnrollmentID, int _CurriculumID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipAvailableCurriculumCoursesBindingSource.DataSource =
                    (from a in Dbconnection.CurriculumCourses
                     .Include("Course")
                     where a.CurriculumID == _CurriculumID
                     select a).ToList<CurriculumCourse>().Except(
                                                                 (from a in Dbconnection.CurriculumCourses

                                                                  from b in a.CurriculumCourseEnrollments
                                                                  where b.EnrollmentID == _EnrollmentID
                                                                  select a).ToList<CurriculumCourse>()).ToList<CurriculumCourse>();

            };
        }
        private void populateApprienticeshipLinkedCourse(int _EnrollmentID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                apprenticeshipLinkedCurriculumCoursesBindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                    .Include("Course")
                                                                                 from b in a.CurriculumCourseEnrollments
                                                                                 where b.EnrollmentID == _EnrollmentID
                                                                                 select a).ToList<CurriculumCourse>();
            };
        }
        #endregion

        #region Control Event Methods
        private void tabEnrollmentWorkbench_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((tabEnrollmentWorkbench).SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    this.refreshApprenticeship();
                    if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
                    {
                        populateApprenticeshipDocumnetTypes(EnumDepartments.Apprenticeship);
                        this.refreshApprenticeshipEnrollmentLinkedCourses();
                    }
                    break;
                case 2:

                    break;
                case 3:

                    break;

                case 4:
                    break;

                case 5:

                    break;
                default:

                    break;
            }
        }
        #endregion

        #region Logical Control

        #endregion
        #endregion

        private void dgvAprenticeshipTab_Enrollment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);

                    row.Cells[colApprenticeshipCurriculum.Index].Value = EnrollmentObj.Curriculum.CurriculumName.ToString();
                    if (EnrollmentObj.ApprienticeshipEnrollment != null)
                    {
                        row.Cells[colApprenticeshipSection.Index].Value = EnrollmentObj.ApprienticeshipEnrollment.LookupSectionalEnrollmentType.LookupSectionalEnrollmentTypeName.ToString();

                    }
                    var CurriculumEnquiryObj = EnrollmentObj.CurriculumEnquiries.FirstOrDefault<CurriculumEnquiry>(); ;
                    if (CurriculumEnquiryObj != null)
                    {
                        row.Cells[colApprenticeshipEnqiry.Index].Value = CurriculumEnquiryObj.EnquiryID.ToString();
                    }


                }
            }
        }
        private void dgvAprenticeshipTab_Enrollment_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void dgvApprenticeshipTab_PrerequisiteCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);

                    row.Cells[colApprenticeshipPreRequisiteCurriculum.Index].Value = EnrollmentObj.Curriculum.CurriculumName.ToString();

                    CurriculumCourse CurriculumCourseObj = (from a in EnrollmentObj.CurriculumCourseEnrollments
                                                            where a.CurriculumCourse.CurriculumID == EnrollmentObj.CurriculumID
                                                            select a.CurriculumCourse)
                                                            .FirstOrDefault<CurriculumCourse>();
                    row.Cells[colApprenticeshipPreRequisiteCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                    row.Cells[colApprenticeshipPrerequisteProcessingStatus.Index].Value = EnrollmentObj.LookupEnrollmentProgressState.EnrollmentProgressCurrentState.ToString();


                }
            }
        }
        private void dgvApprenticeshipTab_PrerequisiteCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void enrollmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshApprenticeshipCoursePreRequisites();
            if (apprenticeshipEnrollmentBindingSource.List.Count > 0)
            {
                populateApprenticeshipDocumnetTypes(EnumDepartments.Apprenticeship);
                this.refreshApprenticeshipEnrollmentLinkedCourses();
            }
        }
        private void dgvApprenticeshipTab_PrerequisiteCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:

                    break;
                case 1:
                    frmEnrollmentException frm1 = new frmEnrollmentException();
                    frm1.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;
                    frm1.SelectedEnrollment = (Enrollment)apprenticeshipPreRequisteCurriculumCourseBindingSource.Current;
                    //int x = (int)dgvAprenticeshipTab_Enrollment.Rows[dgvAprenticeshipTab_Enrollment.CurrentRow.Index].Cells[colApprenticeshipEnqiry.Index].Value;
                    frm1.EnquiryID = Convert.ToInt32(dgvAprenticeshipTab_Enrollment.Rows[dgvAprenticeshipTab_Enrollment.CurrentRow.Index].Cells[colApprenticeshipEnqiry.Index].Value);
                    frm1.ShowDialog();
                    int iCurrentPosition = apprenticeshipPreRequisteCurriculumCourseBindingSource.Position;
                    apprenticeshipPreRequisteCurriculumCourseBindingSource.ResetItem(iCurrentPosition);
                    //refreshApprenticeshipCoursePreRequisites();
                    //apprenticeshipPreRequisteCurriculumCourseBindingSource.Position = iCurrentPosition;
                    break;
                case 2:
                    frmScheduleApprenticeship frm = new frmScheduleApprenticeship();
                    frm.ShowDialog();
                    break;
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colApprenticeshipEnrollmentAvailableCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void dgvApprenticeshipTab_PrerequisiteCourses_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (e.ColumnIndex)
            {

                case 0:


                    var FileObj = fileBindingSource.Current;
                    File x = new File();
                    //loop through the properties of the object you want to covert:          
                    foreach (PropertyInfo pi in FileObj.GetType().GetProperties())
                    {
                        try
                        {
                            //get the value of property and try 
                            //to assign it to the property of T type object:
                            x.GetType().GetProperty(pi.Name).SetValue(x, pi.GetValue(FileObj, null), null);
                        }
                        catch { }
                    }
                    folderBrowserDialogForDownloading.ShowDialog();

                    if (folderBrowserDialogForDownloading.SelectedPath.Length > 0)
                    {
                        try
                        {
                            File CurrentFile = FileHandeling.GetFile(x.ImageID);
                            string path = folderBrowserDialogForDownloading.SelectedPath + "\\" + x.FileName;
                            System.IO.File.WriteAllBytes(path, CurrentFile.FileImage);
                            MessageBox.Show(x.FileName + ", Successfully Saved to: " + path, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    break;
            }
        }

        private void btnEditCourseSelection_Click(object sender, EventArgs e)
        {
            frmEnrollmentCourseSelection frm = new frmEnrollmentCourseSelection();
            frm.CurrentEnrollemnt = (Enrollment)apprenticeshipEnrollmentBindingSource.Current;
            frm.ShowDialog();
        }

        private void dgvAprenticeshipTab_Enrollment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Enrollment EnrollmentObj = ((Enrollment)apprenticeshipEnrollmentBindingSource.Current);
            CurriculumEnquiry CurriculumEnquiryObj;
            Data.Models.Enquiry CurrentEnquiryObj;


            switch (e.ColumnIndex)
            {
                case 1:

                    using (var Dbconnection = new MCDEntities())
                    {

                        CurriculumEnquiryObj = (from a in Dbconnection.CurriculumEnquiries
                                                from b in a.Enrollments
                                                where
                                                b.EnrollmentID == EnrollmentObj.EnrollmentID &&
                                                a.CurriculumID == EnrollmentObj.CurriculumID
                                                select a).FirstOrDefault<CurriculumEnquiry>();

                        CurrentEnquiryObj = (from a in Dbconnection.Enquiries
                                             where a.EnquiryID == CurriculumEnquiryObj.EnquiryID
                                             select a)
                                            .Include("Individuals")
                                            .Include("Individuals.ContactDetails")
                                            .FirstOrDefault<Data.Models.Enquiry>();
                    };

                    frmSendEmail frm = new frmSendEmail();

                    List<ContactDetail> CustomEmailPerson = (from a in CurrentEnquiryObj.Individuals
                                                             from b in a.ContactDetails
                                                             where b.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address
                                                             select b).ToList<ContactDetail>();

                    //Sets the Email Address For the Currently Selected Contact For this Enquiry
                    foreach (ContactDetail ConDetObj in CustomEmailPerson)
                    {
                        if (frm.txtTestingToAddress.Text.Length > 0)
                        {
                            frm.txtTestingToAddress.Text += ";";
                        }
                        frm.txtTestingToAddress.Text += ConDetObj.ContactDetailValue;
                    }

                    frm.txtTestSubject.Text = "Enquiry No: ( " + CurrentEnquiryObj.EnquiryID + "-" + CurriculumEnquiryObj.CurriculumEnquiryID + " ) Enquiry Feed Back";
                    frm.txtTestMessage.Text = "Good Day \nThis is regarding the processing of your Enrollemnt - Ref: " + EnrollmentObj.EnrollmentID + "\n";
                    frm.ShowDialog();
                    using (var Dbconnection = new MCDEntities())
                    {
                        EquiryHistory hist = new EquiryHistory
                        {
                            EnquiryID = CurrentEnquiryObj.EnquiryID,
                            EmployeeID = this.CurrentEmployeeLoggedIn.EmployeeID,
                            LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Custom_Email_Message_Sent,
                            DateEnquiryUpdated = DateTime.Now,
                            EnquiryNotes = "Custom Message Sent To Client Via Email\nSubject of the Message was:\n\n{" + frm.txtTestSubject.Text + "}\n\nBody Of the Message read:\n" + frm.txtTestMessage.Text
                        };
                        Dbconnection.EquiryHistories.Add(hist);
                        int IsSaved = Dbconnection.SaveChanges();
                        //if (IsSaved > 0)
                        //{
                        //    Dbconnection.CurriculumEnquiries.Attach(CE);
                        //    CE.LastUpdated = DateTime.Now;
                        //    Dbconnection.Entry<CurriculumEnquiry>(CE).State = EntityState.Modified;
                        //    Dbconnection.SaveChanges();

                        //}
                        //dgvNewEnquiryTab_CurriculumEnquiry.Refresh();
                    };
                    break;
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
