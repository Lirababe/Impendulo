using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Impendulo.Data.Models;
using System.Data.Entity;
using Impendulo.Common.Enum;
using Impendulo.StudentForms.Development;
using Impendulo.Common.FileHandeling;
using Impendulo.Development.Students;

namespace Impendulo.WizardForm.ClientEnquiry.Development
{
    public partial class frmApprenticeshipEnrollmentFormV2 : MetroForm
    {



        int iCurrentPosition = 0;
        //MCDEntities Dbconnection;
        //Student StudentObj;
        public Enrollment CurrentEnrollments { get; set; }
        public Student CurrentSelectedStudent { get; set; }
        public CurriculumEnquiry CurrentCurriculumEnquiry { get; set; }
        private IList<File> CurrentEnrollmentFormDocument { get; set; }
        private IList<File> CurrentIDDocument { get; set; }

        public Boolean IsSuccessfullySaved { get; set; }

        private Boolean MustSaveItems = false;

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }

        public frmApprenticeshipEnrollmentFormV2()
        {
            InitializeComponent();
            IsSuccessfullySaved = false;
            CurrentEnrollmentFormDocument = new List<File>();
            CurrentIDDocument = new List<File>();
        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {


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



            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Forms Sections

        #region Page 1  - Enrollmrnt Type Selection

        #region Controls Events
        private void picSearchStudents_Click(object sender, EventArgs e)
        {
            List<Student> StudentExcemptionList = new List<Student>();

            using (var Dbconnection = new MCDEntities())
            {
                //Loadds the associated Collections in this case the Enrollment with their associated Students that are enrolled.
                Dbconnection.CurriculumEnquiries.Attach(CurrentCurriculumEnquiry);
                //Load all enrollments that linked to the Enquiry Item.
                Dbconnection.Entry(CurrentCurriculumEnquiry).Collection(a => a.Enrollments).Load();
                foreach (Enrollment EnrollmentObj in CurrentCurriculumEnquiry.Enrollments)
                {
                    //Load the student linked to the enrollment
                    Dbconnection.Entry(EnrollmentObj).Reference(a => a.Student).Load();
                    StudentExcemptionList.Add(EnrollmentObj.Student);
                }
            };
            using (frmStudentSearchForStudent frm = new frmStudentSearchForStudent())
            {
                //Set the list of student that are already Enrolled for this Enquiry Item.
                frm.StudentExpceptionList = StudentExcemptionList;
                frm.ShowDialog();
                if (frm.CurrentSelectedStudent != null)
                {
                    txtStudentFullName.Text = frm.CurrentSelectedStudent.Individual.FullName;
                    txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
                    txtStudentNember.Text = frm.CurrentSelectedStudent.StudentID.ToString();
                    CurrentSelectedStudent = frm.CurrentSelectedStudent;
                    //Summary Fields
                    txtSummaryFullName.Text = txtStudentFullName.Text;
                    txtSummaryIDNumber.Text = txtStudentIdNumber.Text;
                    txtSummaryStudentNumber.Text = txtStudentNember.Text;
                    picbtnEditCurrentStudent.Visible = true;
                }
                else
                {
                    picbtnEditCurrentStudent.Visible = false;
                    txtStudentFullName.Clear();
                    txtStudentIdNumber.Clear();
                    txtStudentNember.Clear();
                    //Summary Fields
                    txtSummaryFullName.Clear();
                    txtSummaryIDNumber.Clear();
                    txtSummaryStudentNumber.Clear();
                    CurrentSelectedStudent = null;
                }
            };
        }
        private void picbtnEditCurrentStudent_Click(object sender, EventArgs e)
        {
            using (frmStudentAddUpdate frm = new frmStudentAddUpdate(CurrentSelectedStudent.StudentID))
            {
                //frm.StudentID = this.CurrentSelectedStudent.StudentID;
                //frm.CurrentSelectedStudent = CurrentSelectedStudent;
                frm.ShowDialog();

                txtStudentFullName.Text = frm.CurrentSelectedStudent.Individual.IndividualFirstName + " " + frm.CurrentSelectedStudent.Individual.IndividualLastname;
                txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
                txtStudentNember.Text = frm.CurrentSelectedStudent.StudentID.ToString();
                //Summary Detrials
                txtSummaryFullName.Text = txtStudentFullName.Text;
                txtSummaryIDNumber.Text = txtStudentIdNumber.Text;
                txtSummaryStudentNumber.Text = txtStudentNember.Text;
                CurrentSelectedStudent = frm.CurrentSelectedStudent;
            }
                //frmAddUpdateStudent frm = new frmAddUpdateStudent();
           

        }

        #endregion

        #region Logical Control Metods


        #endregion



        #endregion

        #region Page 2 

        #region Refresh Methods



        #endregion

        #region Populate Methods

        #endregion

        #region Control Events

        private void radSelectSection13_CheckedChanged(object sender, EventArgs e)
        {
            lblCurentlySelectedEnrollmentType.Text = lblCurentlySelectedEnrollmentType.Text.Replace("28", "13");
            lblSummaryEnrollmentSelectionType.Text = lblCurentlySelectedEnrollmentType.Text;
        }

        private void radSelectSection28_CheckedChanged(object sender, EventArgs e)
        {
            lblCurentlySelectedEnrollmentType.Text = lblCurentlySelectedEnrollmentType.Text.Replace("13", "28");
            lblSummaryEnrollmentSelectionType.Text = lblCurentlySelectedEnrollmentType.Text;
        }
        private void populateFileSummaryList()
        {
            txtSummaryEnrollmentFormAttachments.Clear();
            txtSummaryIDDocumentAttachemnts.Clear();
            foreach (File f in CurrentEnrollmentFormDocument)
            {
                txtSummaryEnrollmentFormAttachments.Text += f.FileName + "." + f.FileExtension + "\n";
            }

            foreach (File f in CurrentIDDocument)
            {
                txtSummaryIDDocumentAttachemnts.Text += f.FileName + "." + f.FileExtension + "\n";
            }
        }

        private void lnkUploadEnrollmentForm_Click(object sender, EventArgs e)
        {
            removeAllEnrollmentForms();
            CurrentEnrollmentFormDocument = FileHandeling.UploadFile();
            if (CurrentEnrollmentFormDocument.Count > 0)
            {

                lblEnrollmentFormStatus.Text = "Completed Uploaded";
                lblEnrollmentFormStatus.BackColor = Color.Green;
                chkEnrollmentFormNotAvailable.Checked = true;

            }
            else
            {
                lblEnrollmentFormStatus.Text = "Not Uploaded";
                lblEnrollmentFormStatus.BackColor = Color.Red;
            }
            populateFileSummaryList();
        }

        private void removeAllEnrollmentForms()
        {
            if (CurrentEnrollmentFormDocument.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (File f in CurrentEnrollmentFormDocument)
                    {
                        Dbconnection.Files.Attach(f);
                    }

                    Dbconnection.Files.RemoveRange(CurrentEnrollmentFormDocument);
                    Dbconnection.SaveChanges();
                    CurrentEnrollmentFormDocument.Clear();
                    lblEnrollmentFormStatus.Text = "Not Uploaded";
                    lblEnrollmentFormStatus.BackColor = Color.Red;
                };
            }
            populateFileSummaryList();
        }
        private void lnkUploadIDDocument_LinkClicked(object sender, EventArgs e)
        {
            removeAllIDDocuments();

            CurrentIDDocument = FileHandeling.UploadFile();
            if (CurrentIDDocument.Count > 0)
            {

                lblIDDocumentStatus.Text = "Completed Uploaded";
                lblIDDocumentStatus.BackColor = Color.Green;
                chkIDDocumentNotAvailable.Checked = true;

            }
            else
            {
                lblIDDocumentStatus.Text = "Not Uploaded";
                lblIDDocumentStatus.BackColor = Color.Red;
            }
            populateFileSummaryList();
        }

        private void removeAllIDDocuments()
        {
            if (CurrentIDDocument.Count > 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (File f in CurrentIDDocument)
                    {
                        Dbconnection.Files.Attach(f);
                    }
                    Dbconnection.Files.RemoveRange(CurrentIDDocument);
                    Dbconnection.SaveChanges();
                    CurrentIDDocument.Clear();
                    lblIDDocumentStatus.Text = "Not Uploaded";
                    lblIDDocumentStatus.BackColor = Color.Red;
                };
            }
            populateFileSummaryList();
        }

        private void chkEnrollmentFormNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEnrollmentFormNotAvailable.Checked)
            {
                removeAllEnrollmentForms();
            }
        }

        private void chkIDDocumentNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkIDDocumentNotAvailable.Checked)
            {
                removeAllIDDocuments();
            }
        }
        #endregion

        #region Logic Control Methods



        #endregion
        #endregion

        #region Page 3 

        #region Refresh Methods

        #endregion

        #region Populate Methods

        #endregion

        #region Control Events


        #endregion

        #region logical Control Methods

        #endregion

        #endregion

        #region Page 4 - Summary Confirmation

        #region Control Methods



        #endregion

        #endregion


        #endregion

        #region Wizard Comopnents
        #region "Navigation Controls"
        private void navigateForward()
        {
            if (ValidateStep())
            {
                if (iCurrentPosition + 1 < MainflowLayoutPanel.Controls.Count)
                {
                    //if step validation is passed the next window is display by incrementing the IcurrentPosition Counter.
                    iCurrentPosition++;
                }
                else
                {
                    //on last step which will close if the finish b=button is selected.
                    DialogResult res = MessageBox.Show("Are Details Correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == res)
                    {
                        MustSaveItems = true;
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
            if (iCurrentPosition - 1 >= 0)
            {
                iCurrentPosition--;
            }
            else
            {

                //iCurrentPosition = 5;
            }
            //Hide All Panels inside the MainFlowPanel
            //MainflowLayoutPanel
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }


        private void setNavigationControls()
        {
            if (iCurrentPosition == 0)
            {
                btnPreviousSection.Visible = false;
                btnNextSection.Text = "Next";
            }
            else
            {
                if (iCurrentPosition == MainflowLayoutPanel.Controls.Count - 1)
                {
                    btnNextSection.Text = "Process";
                    btnNextSection.ImageIndex = 2;
                }
                else
                {
                    btnNextSection.Text = "Next";
                    btnNextSection.ImageIndex = 0;
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
                    if (Convert.ToInt32(lblObj.Tag.ToString()) == iCurrentPosition)
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        lblObj.Font = new Font(lblObj.Font, FontStyle.Regular);
                    }
                }
            }
            double dblPercentageComplete = (((Convert.ToDouble(iCurrentPosition + 1) / Convert.ToDouble(iAmountOfSteps))) * 100);
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
                    if (Convert.ToInt32(gbObj.Tag.ToString()) == iCurrentPosition)
                    {
                        gbObj.Show();
                        gbObj.Width = MainflowLayoutPanel.Width - 10;
                        gbObj.Height = MainflowLayoutPanel.Height - 10;
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
            switch (iCurrentPosition)
            {
                case 0:
                    this.loadupEnquiryContactSelectionType();
                    break;
                case 1:
                    this.loadupEnquiryContactSelection();
                    break;
                case 2:
                    this.loadupEnquiryCurriculumSelection();
                    break;
                case 3:
                    this.loadupEnquiryConfirmation();
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
            switch (iCurrentPosition)
            {
                case 0:
                    break;
                case 1:
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
                    bRtn = false;
                    break;
            }

            return bRtn;
        }

        #region "Each Wizard Page Loadup"
        private void loadupEnquiryContactSelectionType()
        {


        }
        private void loadupEnquiryContactSelection()
        {





        }
        private void loadupEnquiryCurriculumSelection()
        {



        }


        private void loadupEnquiryConfirmation()
        {

        }







        #endregion

        #endregion

        #endregion

        private void frmApprenticeshipEnrollmentFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MustSaveItems)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    /*Step 1 Begin - Saves Main Enrollment*/
                    CurrentEnrollments = new Enrollment();
                    Dbconnection.CurriculumEnquiries.Attach(CurrentCurriculumEnquiry);

                    EnumSectionalEnrollmentTypes EnrollmenTypeSelection;
                    if (radSelectSection13.Checked)
                    {
                        EnrollmenTypeSelection = EnumSectionalEnrollmentTypes.Section_13;
                    }
                    else
                    {
                        EnrollmenTypeSelection = EnumSectionalEnrollmentTypes.Section_28;
                    }

                    CurrentEnrollments.EnrolmentParentID = 0;
                    CurrentEnrollments.LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.New_Enrollment;
                    CurrentEnrollments.CurriculumID = CurrentCurriculumEnquiry.CurriculumID;
                    CurrentEnrollments.IndividualID = CurrentSelectedStudent.StudentID;
                    CurrentEnrollments.DateIntitiated = DateTime.Now;
                    CurrentEnrollments.ApprienticeshipEnrollment = new ApprienticeshipEnrollment()
                    {
                        LookupSectionalEnrollmentTypeID = (int)EnrollmenTypeSelection
                    };


                    CurrentCurriculumEnquiry.Enrollments.Add(CurrentEnrollments);

                    Dbconnection.SaveChanges();
                    /*End Step 1 */

                    /*Step 2 Get PreRequiestes Courses and and load them with the main enrollment*/

                    List<CurriculumPrequisiteCourse> CPC = (from a in Dbconnection.CurriculumPrequisiteCourses
                                                            where a.CurriculumID == CurrentCurriculumEnquiry.CurriculumID
                                                            select a)
                                                            .Include("CurriculumCourse")
                                                            .ToList<CurriculumPrequisiteCourse>();

                    //Get All The Possible Cuuriculum that for partof the Pre-Requisites
                    List<int> PreRequisiteCurriculumID = (from a in CPC
                                                          select a.CurriculumCourse.CurriculumID)
                                                          .Distinct<int>()
                                                          .ToList<int>();
                    //Create Enrollment for each possible Curriculum that that forms part of the list pre-requisite Courses.
                    foreach (int CurriculumIDForPreRquisiteCourseEnrollment in PreRequisiteCurriculumID)
                    {
                        //Creates a Enrollment Enrty for the Curriculum
                        Enrollment PreRequisisteCourseEnrollment = new Enrollment
                        {
                            EnrolmentParentID = CurrentEnrollments.EnrollmentID,
                            LookupEnrollmentProgressStateID = (int)EnumEnrollmentProgressStates.In_Progress,
                            CurriculumID = CurriculumIDForPreRquisiteCourseEnrollment,
                            IndividualID = CurrentSelectedStudent.StudentID,
                            DateIntitiated = DateTime.Now
                        };
                        Dbconnection.Enrollments.Add(PreRequisisteCourseEnrollment);
                        Dbconnection.SaveChanges();
                        //links each pre-Requisite Course to the Curriculum Linked.
                        foreach (CurriculumCourse CurriculumCourseToLink in (from a in CPC
                                                                  where a.CurriculumCourse.CurriculumID == CurriculumIDForPreRquisiteCourseEnrollment
                                                                  select a.CurriculumCourse)
                                           .Distinct<CurriculumCourse>().
                                           ToList<CurriculumCourse>())
                        {
                            Dbconnection.CurriculumCourseEnrollments.Add(new CurriculumCourseEnrollment
                            {
                                CurriculumCourseID = CurriculumCourseToLink.CurriculumCourseID,
                                EnrollmentID = PreRequisisteCourseEnrollment.EnrollmentID,
                                 CourseCost = CurriculumCourseToLink.Cost // Set the linked course to the default Cost for the course
                            });
                        }
                        //Saves the sub set of Pre-Requisite Curriculum and linked courses.
                        Dbconnection.SaveChanges();
                    }


                    ///* End Step 3*/

                    foreach (File f in CurrentEnrollmentFormDocument)
                    {
                        CurrentEnrollments.EnrollmentDocuments.Add(new EnrollmentDocument()
                        {
                            FileID = f.FileID,
                            EnrollmentID = CurrentEnrollments.EnrollmentID,
                            LookupEnrollmentDocumentTypeID = (int)EnumEnrollentDocumentTypes.Enrollment_Documents
                        });
                    }
                    foreach (File f in CurrentIDDocument)
                    {
                        CurrentEnrollments.EnrollmentDocuments.Add(new EnrollmentDocument()
                        {
                            FileID = f.FileID,
                            EnrollmentID = CurrentEnrollments.EnrollmentID,
                            LookupEnrollmentDocumentTypeID = (int)EnumEnrollentDocumentTypes.ID_Documents
                        });
                    }

                    //Dbconnection.SaveChanges();
                    EquiryHistory hist = new EquiryHistory
                    {
                        EnquiryID = CurrentCurriculumEnquiry.EnquiryID,
                        EmployeeID = CurrentEmployeeLoggedIn.EmployeeID,
                        LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enrollment_Student_Successfully_Enrolled,
                        DateEnquiryUpdated = DateTime.Now,
                        EnquiryNotes = "Initial Enrollment Completed Successfully for the the Following Individual - " + CurrentSelectedStudent.Individual.FullName.ToString() + "\n Enquiry Ref# - " + CurrentCurriculumEnquiry.EnquiryID

                    };
                    Dbconnection.EquiryHistories.Add(hist);
                    int IsSaved = Dbconnection.SaveChanges();
                    IsSuccessfullySaved = true;
                };
            }
        }





    }
}
