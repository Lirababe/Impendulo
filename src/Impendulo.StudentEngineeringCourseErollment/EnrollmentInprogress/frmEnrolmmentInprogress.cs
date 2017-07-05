using Impendulo.Common.Enum;
using Impendulo.Common.FileHandeling;
using Impendulo.Data.Models;
using Impendulo.Enquiry.Deployment.ViewHistory;

using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentCourseSelection;
using Impendulo.StudentEngineeringCourseErollment.Development.EnrollmentException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.ScheduleApprientice;
using Impendulo.Email.Development;
using Impendulo.StudentEngineeringCourseErollment.Development.EnrollmentException;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress
{
    public partial class frmEnrolmmentInprogress : MetroForm
    {
        public frmEnrolmmentInprogress()
        {
            InitializeComponent();

        }

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
        public int CurrentEquiryID { get; set; }
        private void frmEnrolmmentInprogress_Load(object sender, EventArgs e)
        {
            CurrentSelectedDepartment = EnumDepartments.Apprenticeship;
            this.refreshEnrollment();
           

        }

        private void CheckIfAllPreRequisitesAreCompletedRefresh()
        {
            if (CheckIfAllPreRequisitesAreCompleted())
            {
                btnEditCourseSelection.Enabled = false;
            }
            else
            {
                btnEditCourseSelection.Enabled = true;
            }
        }

        private Boolean CheckIfAllPreRequisitesAreCompleted()
        {
            Boolean Rtn = false;

            //Check to see if there are any prerequisites
            if (enrollmentPrerequisitesBindingSource.Count > 0)
            {
                //checks to see if tehere are any are incompleted.
                foreach (Enrollment Enroll in enrollmentPrerequisitesBindingSource.List)
                {
                    if (Enroll.LookupEnrollmentProgressStateID == (int)Common.Enum.EnumEnrollmentProgressStates.In_Progress)
                    {
                        return true;
                    }
                }
            }

            return Rtn;
        }

        private void CheckIFThereAreCoursesToSchedule()
        {
            if(curriculumCourseLinkedToEnrollmentBindingSource.Count > 0)
            {
                btnScheduleEnrollement.Enabled = true;
            }
            else
            {
                btnScheduleEnrollement.Enabled = false;
            }
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
                    radObj.Text = Enrolltype.EnrollmentDocumentType;
                    if (IsFirst)
                    {
                        populateApprenticeshipEnrollmentDocuments(Enrolltype.LookupEnrollmentDocumentTypeID);
                        radObj.Checked = true;
                        IsFirst = false;

                    };
                    radObj.Tag = Enrolltype.LookupEnrollmentDocumentTypeID;
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
                Enrollment Enroll = ((Enrollment)(enrollmentBindingSource.Current));
                //fileBindingSource.DataSource = (from a in Dbconnection.ApprenticeshipEnrollmentDocuments
                //                                where a.EnrollmentID == Enroll.EnrollmentID
                //                                    && a.LookupEnrollentDocumentTypeID == _EnrollentDocumentTypeID
                //                                select new
                //                                {
                //                                    ImageID = a.File.ImageID,
                //                                    FileName = a.File.FileName + "." + a.File.FileExtension,
                //                                    DateCreated = a.File.DateCreated
                //                                }).ToList();

            };
        }
        private void RadObj_ApprenticeshipDocuments_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radObj = (RadioButton)sender;
            populateApprenticeshipEnrollmentDocuments((int)radObj.Tag);
        }
        #endregion


        #region Refresh Methods

        private void refreshEnrollment()
        {
            populateApprienticeship();
            if (enrollmentBindingSource.List.Count > 0)
            {
                this.populateApprenticeshipDocumnetTypes((EnumDepartments)((Enrollment)enrollmentBindingSource.Current).Curriculum.DepartmentID);
                this.refreshEnrollmentLinkedCourses();
                //this.refreshScheduleCoursePriliminaryDate();
                


            }
        }
        private void refreshEnrollmentCoursePreRequisites()
        {
            
            populateApprenticeshipCoursePreRequisites();
            

        }


        private void refreshEnrollmentLinkedCourses()
        {
            int _EnrollmentID = 0;
            if (enrollmentBindingSource.List.Count > 0)
            {
                _EnrollmentID = ((Enrollment)(enrollmentBindingSource.Current)).EnrollmentID;
            }
            populateApprienticeshipLinkedCourse(_EnrollmentID);
            this.CheckIFThereAreCoursesToSchedule();
            CheckIfAllPreRequisitesAreCompletedRefresh();



        }

        private void refreshScheduleCoursePriliminaryDate()
        {
            //int _EnrollmentID = 0;
            //if (enrollmentBindingSource.List.Count > 0)
            //{
            //    _EnrollmentID = ((Enrollment)(enrollmentBindingSource.Current)).EnrollmentID;
            //}
            //populateCourseSchedulePreliminaryDates(_EnrollmentID);
            
        }

        #endregion

        #region Populate methods
        private void clearDataBindingSources()
        {
            enrollmentBindingSource.Clear();
        }
        private void populateApprienticeship()
        {


            this.clearDataBindingSources();
            using (var Dbconnection = new MCDEntities())
            {

                List<Enrollment> AllEnrollments =
                  (from a in Dbconnection.Enrollments
                       // from b in a.CurriculumEnquiries
                   orderby a.EnrollmentID descending
                   where
                      //Only List Emrollment that are not yet Completed(Scheduled).
                      a.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress
                   &&
                   //Lists all Enrollemt that from part of the Apprenticeship Department
                    a.Curriculum.DepartmentID == (int)CurrentSelectedDepartment
                   //&&
                   //The enquiry is not closed - means that the client has not cancelled the Enrollment or enquiry.
                   //b.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed
                   // orderby b.EnquiryID descending, a.DateIntitiated descending
                   select a)
                      .Include("Student")
                      .Include("Student.Individual")
                      .Include("Student.Individual.LookupTitle")
                      .Include("CurriculumEnquiries")
                      .Include("CurriculumCourseEnrollments")
                      .Include("Curriculum")
                      // .Take<Enrollment>(50)
                      .ToList<Enrollment>();

                // lists the main Enrollemnt Query for the Apprenticeship

                //if (IsLoadingPreRequisiteEnrollment)
                //{
                //    AllEnrollments = (from a in AllEnrollments
                //                      where a.EnrolmentParentID > 0
                //                      select a).ToList<Enrollment>();
                //}
                //else
                //{
                //    AllEnrollments = (from a in AllEnrollments
                //                      where a.EnrolmentParentID == 0
                //                      select a).ToList<Enrollment>();
                //}
                //if (CurrentEquiryID > 0)
                //{
                //    AllEnrollments = (from a in AllEnrollments
                //                      from b in a.CurriculumEnquiries
                //                      where b.EnquiryID == CurrentEquiryID
                //                      select a).ToList<Enrollment>();
                //}
                if (CurrentEnrollmentID > 0)
                {
                    AllEnrollments = (from a in AllEnrollments
                                      where a.EnrollmentID == CurrentEnrollmentID
                                      select a).ToList<Enrollment>();
                }
                enrollmentBindingSource.DataSource = AllEnrollments;
            };
        }
        private void populateApprenticeshipCoursePreRequisites()
        {
            Enrollment EnrollObj = (Enrollment)enrollmentBindingSource.Current;
            if (EnrollObj != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    enrollmentPrerequisitesBindingSource.DataSource = (from a in Dbconnection.Enrollments
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
                enrollmentPrerequisitesBindingSource.Clear();
            }


        }


        private void populateApprienticeshipLinkedCourse(int _EnrollmentID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseLinkedToEnrollmentBindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                                 .Include("Course")
                                                                              from b in a.CurriculumCourseEnrollments
                                                                              where b.EnrollmentID == _EnrollmentID
                                                                              select a).ToList<CurriculumCourse>();
            };
        }

        #endregion

        #region Control Event Methods

        #region Databinding Complete Events Of DataGridView Controls
        private void dgvEnrollment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);

                    row.Cells[colApprenticeshipCurriculum.Index].Value = EnrollmentObj.Curriculum.CurriculumName.ToString();
                    //if (EnrollmentObj.ApprienticeshipEnrollment != null)
                    //{
                    //    row.Cells[colApprenticeshipSection.Index].Value = EnrollmentObj.ApprienticeshipEnrollment.LookupSectionalEnrollmentType.LookupSectionalEnrollmentTypeName.ToString();

                    //}
                    var CurriculumEnquiryObj = EnrollmentObj.CurriculumEnquiries.FirstOrDefault<CurriculumEnquiry>(); ;
                    if (CurriculumEnquiryObj != null)
                    {
                        row.Cells[colApprenticeshipEnqiry.Index].Value = CurriculumEnquiryObj.EnquiryID.ToString();
                    }
                    else
                    {
                        using (var Dbconnection = new MCDEntities())
                        {
                            CurriculumEnquiryObj =
                              (from a in Dbconnection.Enrollments
                                   // from b in a.CurriculumEnquiries
                               orderby a.EnrollmentID descending
                               where
                                 a.EnrollmentID == EnrollmentObj.EnrolmentParentID
                               select a)
                                  .Include("CurriculumEnquiries")
                                  .FirstOrDefault<Enrollment>().CurriculumEnquiries.FirstOrDefault<CurriculumEnquiry>();
                            row.Cells[colApprenticeshipEnqiry.Index].Value = CurriculumEnquiryObj.EnquiryID.ToString();

                        };
                    }


                }
            }
        }

        private void dgvPrerequisiteCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void dgvEnollmentFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgvEnrollmenLinkedCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
        #endregion
        #endregion

        #region Logical Control

        #endregion



        private void dgvEnrollment_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvPrerequisiteCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvEnollmentFiles_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvEnrollmenLinkedCurriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvEnrollment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Enrollment EnrollmentObj = ((Enrollment)enrollmentBindingSource.Current);


            switch (e.ColumnIndex)
            {
                case 0:
                    frmEquiryViewHistory frm5 = new frmEquiryViewHistory();
                    //frm5.CurrentEnquiryID = EnrollmentObj.CurriculumEnquiries.Where(a=>a.Enrollments.;
                    frm5.ShowDialog();

                    break;
            }
        }

        private void dgvPrerequisiteCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:

                    break;
                case 1:
                    frmEnrollmentException frm1 = new frmEnrollmentException();
                    frm1.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;
                  //  frm1.SelectedEnrollment = (Enrollment)enrollmentPrerequisitesBindingSource.Current;
                    //int x = (int)dgvAprenticeshipTab_Enrollment.Rows[dgvAprenticeshipTab_Enrollment.CurrentRow.Index].Cells[colApprenticeshipEnqiry.Index].Value;
                    frm1.EnquiryID = Convert.ToInt32(dgvEnrollment.Rows[dgvEnrollment.CurrentRow.Index].Cells[colApprenticeshipEnqiry.Index].Value);
                    frm1.ShowDialog();
                    int iCurrentPosition = enrollmentPrerequisitesBindingSource.Position;
                    enrollmentPrerequisitesBindingSource.ResetItem(iCurrentPosition);
                    //refreshApprenticeshipCoursePreRequisites();
                    //apprenticeshipPreRequisteCurriculumCourseBindingSource.Position = iCurrentPosition;
                    break;
                case 3:
                    //frmScheduleApprenticeship frm = new frmScheduleApprenticeship();
                    //frm.ShowDialog();
                    break;
                case 2:
                    Enrollment PreEnrollmentObj = (Enrollment)enrollmentPrerequisitesBindingSource.Current;
                    CurrentEnrollmentID = PreEnrollmentObj.EnrollmentID;
                    CurrentSelectedDepartment = (EnumDepartments)PreEnrollmentObj.Curriculum.DepartmentID;
                    CurrentEquiryID = 0;
                    IsLoadingPreRequisiteEnrollment = true;
                    refreshEnrollment();
                    break;
            }
        }

        private void dgvEnollmentFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            File CurrentFile = FileHandeling.GetFile(x.FileID);
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

        private void dgvEnrollmenLinkedCurriculumCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void enrollmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshEnrollmentCoursePreRequisites();
            if (enrollmentBindingSource.List.Count > 0)
            {
                populateApprenticeshipDocumnetTypes((EnumDepartments)((Enrollment)(enrollmentBindingSource.Current)).Curriculum.DepartmentID);
                this.refreshEnrollmentLinkedCourses();
                this.refreshScheduleCoursePriliminaryDate();
            }
        }

        private void btnCompleteEnrollmentSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnEmailClient_Click(object sender, EventArgs e)
        {
            Enrollment EnrollmentObj = ((Enrollment)enrollmentBindingSource.Current);
            CurriculumEnquiry CurriculumEnquiryObj;
            Data.Models.Enquiry CurrentEnquiryObj;
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
            if (frm.IsSent)
            {
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
                };
            }
        }

        private void btnEditCourseSelection_Click(object sender, EventArgs e)
        {
            frmEnrollmentCourseSelection frm = new frmEnrollmentCourseSelection();
            frm.CurrentEnrollemnt = (Enrollment)enrollmentBindingSource.Current;
            frm.ShowDialog();
            refreshEnrollmentLinkedCourses();
        }

        private void btnScheduleEnrollement_Click(object sender, EventArgs e)
        {
            int _CurrentEnrollmentID = ((Enrollment)enrollmentBindingSource.Current).EnrollmentID;
            frmScheduleApprience frm = new frmScheduleApprience();
            frm._EnrolmentID = _CurrentEnrollmentID;
            frm.ShowDialog();
        }

        private void dgvCourseSschedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //DateTimePicker dtp = new DateTimePicker();
            //var gridView = (DataGridView)sender;
            //foreach (DataGridViewRow row in gridView.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {
            //        CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);
            //        //Schedule CourseScheduleObj = (Schedule)(row.DataBoundItem);

            //        row.Cells[colApprenticeshipEnrollmentLinkedCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();

            //        //row.Cells[colApprenticeshipEnrollmentLinkedCourseStartDate.Index].Value = CourseScheduleObj.ScheduleStartDate.ToShortDateString();
            //        //row.Cells[colApprenticeshipEnrollmentLinkedCourseEndtDate.Index].Value = CourseScheduleObj.ScheduleCompletionDate.ToShortDateString();
            //    }
            //}
        }

        DateTimePicker dtp = new DateTimePicker();
        private void dgvCourseSschedule_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //try
            //{
            //    if ((dgvCourseSschedule.Focused) && (dgvCourseSschedule.CurrentCell.ColumnIndex == 1))
            //    {
            //        dtp = new DateTimePicker();
            //        dgvCourseSschedule.Controls.Add(dtp);
            //        dtp.Format = DateTimePickerFormat.Short;
            //        dtp.Visible = false;
            //        dtp.Location = dgvCourseSschedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
            //        dtp.Visible = true;
            //        if (dgvCourseSschedule.CurrentCell.Value != DBNull.Value)
            //        {
            //            dtp.Value = (DateTime)dgvCourseSschedule.CurrentCell.Value;
            //        }
            //        else
            //        {
            //            dtp.Value = DateTime.Today;
            //        }
            //    }
            //    else
            //    {
            //        dtp.Visible = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //dgvCourseSschedule.CellValueChanged += this.dtp_ValueChanged;

        }
        private void dgvCourseSschedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if ((dgvCourseSschedule.Focused) && (dgvCourseSschedule.CurrentCell.ColumnIndex == 1))
            //    {
            //        dtp = new DateTimePicker();
            //        dgvCourseSschedule.Controls.Add(dtp);
            //        dtp.Format = DateTimePickerFormat.Short;
            //        dtp.Visible = false;
            //        dgvCourseSschedule.CurrentCell.Value = dtp.Value.Date;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //dgvCourseSschedule.CellValueChanged += this.dtp_ValueChanged;
        }

        //private void dtp_ValueChanged(object sender, EventArgs e)
        //{
        //    dgvCourseSschedule.CurrentCell.Value = dtp.Text;
        //}

        private void dgvCourseSschedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1)
            //{
            //    dtp = new DateTimePicker();
            //    dgvCourseSschedule.Controls.Add(dtp);
            //    dtp.Format = DateTimePickerFormat.Short;
            //    Rectangle Rectangle = dgvCourseSschedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            //    dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
            //    dtp.Location = new Point(Rectangle.X, Rectangle.Y);

            //    dtp.CloseUp += new EventHandler(dtp_CloseUp);
            //    dtp.TextChanged += new EventHandler(dtp_OnTextChange);


            //    dtp.Visible = true;
            //}

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        //private void dtp_OnTextChange(object sender, EventArgs e)
        //{
        //    dgvCourseSschedule.CurrentCell.Value = dtp.Text.ToString();
        //}
        //void dtp_CloseUp(object sender, EventArgs e)
        //{
        //    dtp.Visible = false;
        //}
    }
}
