using Impendulo.Common.FileHandeling;
using Impendulo.Data;
using Impendulo.Data.Models;
using Impendulo.Data.Models.Enum;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Development.Students
{
    public partial class frmStudentAddUpdate : MetroForm
    {

        public Student CurrentSelectedStudent { get; set; }
        public int CurrentStudentID { get; set; }
        public int CurrentPosition { get; set; }
        public Boolean IsSuccessfullySaved { get; set; }

        private List<Data.Models.File> StudentPictureToUploaded { get; set; }

        private Boolean IsClosingPrematurly { get; set; }

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }

        public frmStudentAddUpdate()
        {
            InitializeComponent();
            CurrentStudentID = 15200;// 15189;// 15188;// 15187;// 15173;
            StudentPictureToUploaded = new List<Data.Models.File>();
            IsSuccessfullySaved = false;
            IsClosingPrematurly = true;

        }

        private void frmStudentAddUpdate_Load(object sender, EventArgs e)
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


            //Initialises the Student If None is provided before Loading the form.

            //PreLoads All Drop Down Controls
            this.refreshAllDropDownControls();
            //Loads the Wizard
            this.CurrentPosition = 0;
            this.setCenterDisplayPanels();
            this.setNavigationControls();
            this.loadupStep();
        }

        #region Refresh 

        private void refreshAllDropDownControls()
        {
            this.populateTitles();
            this.populateEthnicity();
            this.populateGenders();
            this.populateMaritalStatuis();
            this.populateHighestQualifications();
            this.populateAddresTypes();
            this.populateProvinces();
            this.populateCountries();
        }
        private void refreshStudentIDDocumnets()
        {
            populateStudentIDDocuments();
        }


        #endregion


        #region  PreLoad All Wizard DropDown Controls
        #region  Populate Student Form Drop Down Controls

        private void populateAddresTypes()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupAddressTypeBindingSource.DataSource = (from a in Dbconnection.LookupAddressTypes
                                                             select a).ToList<LookupAddressType>();
            };
        }
        private void populateProvinces()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupProvinceBindingSource.DataSource = (from a in Dbconnection.LookupProvinces
                                                          orderby a.Province
                                                          select a).ToList<LookupProvince>();
            };
        }
        private void populateCountries()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupCountryBindingSource.DataSource = (from a in Dbconnection.LookupCountries
                                                         select a).ToList<LookupCountry>();
            };
        }
        /// <summary>
        /// PreLoads the All Title Drop Down Controls.
        /// </summary>
        private void populateTitles()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.lookupTitleBindingSource.DataSource = (from a in Dbconnection.LookupTitles

                                                            select a).ToList<LookupTitle>();
            };
        }
        private void populateEthnicity()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.lookupEthnicityBindingSource.DataSource = (from a in Dbconnection.LookupEthnicities
                                                                orderby a.Ethnicity
                                                                select a).ToList<LookupEthnicity>();
            };
        }
        private void populateGenders()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.lookupGenderBindingSource.DataSource = (from a in Dbconnection.LookupGenders
                                                             orderby a.Gender
                                                             select a).ToList<LookupGender>();
            };
        }
        private void populateMaritalStatuis()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupMartialStatusBindingSource.DataSource = (from a in Dbconnection.LookupMartialStatuses
                                                               orderby a.MaritialStatus
                                                               select a).ToList<LookupMartialStatus>();
            };
        }
        private void populateHighestQualifications()
        {

            using (var Dbconnection = new MCDEntities())
            {
                lookupQualificationLevelBindingSource.DataSource = (from a in Dbconnection.LookupQualificationLevels
                                                                    select a).ToList<LookupQualificationLevel>();
            };
        }
        #endregion

        #endregion

        #region Wizard Page Sections

        #region Student Details Page

        #region Page Logic Methods
        private void LoadStudentPictureFromDataBase()
        {
            //Student StudentObj = (Student)studentBindingSource.Current;

            using (var Dbconnection = new MCDEntities())
            {
                StudentPictureToUploaded = (from a in Dbconnection.StudentPhotos
                                            where a.StudentID == CurrentStudentID
                                            select a.File).ToList<Data.Models.File>();
            };

        }
        private void switchStudentPictureButtons()
        {
            Student StudentObj = (Student)studentBindingSource.Current;

            if (StudentPictureToUploaded.Count > 0)
            {
                this.btnStudentPictureAdd.Visible = false;
                this.btnStudentPictureUpdate.Visible = true;

            }
            else
            {
                this.btnStudentPictureAdd.Visible = true;
                this.btnStudentPictureUpdate.Visible = false;
            }
        }
        private void ShowStudentPicture()
        {
            foreach (Data.Models.File f in StudentPictureToUploaded)
            {
                MemoryStream ms = new MemoryStream(f.FileImage);
                picStudentPicture.Image = new Bitmap(ms);
            }

        }

        #endregion
        #region Control Methods
        private void btnStudentPictureAdd_Click(object sender, EventArgs e)
        {
            StudentPictureToUploaded = FileHandeling.UploadFile(UseMultipleFileSelect: false, AutomaicallyAddFileToDatabase: false, ImagesOnly: true);

            if (StudentPictureToUploaded.Count > 0)
            {
                if (CurrentStudentID != 0)
                {

                    using (var Dbconnection = new MCDEntities())
                    {
                        Data.Models.File f = StudentPictureToUploaded.FirstOrDefault<Data.Models.File>();
                        Dbconnection.Files.Add(f);
                        Dbconnection.SaveChanges();

                        //Dbconnection.Files.Attach(f);
                        Dbconnection.StudentPhotos.Add(new StudentPhoto()
                        {
                            FileID = f.FileID,
                            StudentID = CurrentStudentID,
                            DateUpdated = DateTime.Now,
                            StudentPhotoID = 0
                        });
                        Dbconnection.SaveChanges();
                    };
                }
            }

            ShowStudentPicture();
            switchStudentPictureButtons();

        }
        private void btnStudentPictureUpdate_Click(object sender, EventArgs e)
        {
            List<Data.Models.File> FileToUpdate = FileHandeling.UploadFile(UseMultipleFileSelect: false, AutomaicallyAddFileToDatabase: false, ImagesOnly: true);


            Data.Models.File f = StudentPictureToUploaded.FirstOrDefault<Data.Models.File>();
            if (CurrentStudentID != 0)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Files.Attach(f);
                    Dbconnection.Entry(f).State = EntityState.Modified;
                    f.FileImage = FileToUpdate.First<Data.Models.File>().FileImage;
                    Dbconnection.SaveChanges();

                };
            }
            else
            {
                f.FileImage = FileToUpdate.First<Data.Models.File>().FileImage;
            }
            ShowStudentPicture();
        }
        #endregion
        #endregion

        #region Student ID Documents
        #region Populate Methods
        private void populateStudentIDDocuments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                var StudentIDDocumentFiles = (from a in Dbconnection.StudentIDDocuments
                                              where a.StudentID == this.CurrentStudentID
                                              select new
                                              {
                                                  FileID = a.File.FileID,
                                                  FileName = a.File.FileName,
                                                  FileExtension = a.File.FileExtension,
                                                  DateCreated = a.File.DateCreated,
                                                  ContentType = a.File.ContentType
                                              }).ToList();
                List<Data.Models.File> AllStudentIDDocuments = new List<Data.Models.File>();
                foreach (var obj in StudentIDDocumentFiles)
                {
                    AllStudentIDDocuments.Add(new Data.Models.File()
                    {
                        FileID = obj.FileID,
                        FileName = obj.FileName,
                        ContentType = obj.ContentType,
                        DateCreated = obj.DateCreated,
                        FileExtension = obj.FileExtension
                    });
                }
                fileStudentIDDocumentBindingSource.DataSource = AllStudentIDDocuments;
            };
        }
        #endregion
        #endregion

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



                    try
                    {
                        //ToDo - Catch All Verification and validation on fields before saving.
                        //check and adds the new student to the database or updates the exsiting one.


                        Student StudentObj = (Student)studentBindingSource.Current;
                        using (var Dbconnection = new MCDEntities())
                        {


                            if (StudentObj.ObjectState == EntityObjectState.Added)
                            {
                                Student StudentFound;


                                using (var DbconnectionInner = new MCDEntities())
                                {
                                    StudentFound = (from a in Dbconnection.Students
                                                    where a.StudentIDNumber.Contains(txtStudentIDNumber.Text)
                                                    select a).FirstOrDefault<Student>();
                                };

                                if (txtStudentIDNumber.Text.Length != 0 && StudentFound != null)
                                {
                                    //throw new DbEntityValidationException("(ID Number Invalid) - ID Number Already Exists in the System Please Re-Enter ID Number Or Search Again!");
                                    //MetroMessageBox.Show(this, "(ID Number Invalid) - ID Number Already Exists in the System Please Re-Enter ID Number Or Search Again!", "Error Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                                    MessageBox.Show("(ID Number Invalid) - ID Number Already Exists in the System Please Re-Enter ID Number Or Search Again!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    bRtn = false;
                                    break;
                                }
                                else
                                {
                                    Student NewStudent = new Student()
                                    {
                                        StudentID = 0,
                                        StudentIDNumber = txtStudentIDNumber.Text.ToString(),
                                        EthnicityID = Convert.ToInt32(cboStudentEthnicity.SelectedValue),
                                        GenderID = Convert.ToInt32(cboStudentGender.SelectedValue),
                                        MartialStatusID = Convert.ToInt32(cboStudentMartialStatus.SelectedValue),
                                        QualificationLevelID = Convert.ToInt32(cboStudentHighestQualificationLevel.SelectedValue),
                                        StudentCurrentPosition = "",
                                        StudentlInitialDate = DateTime.Now,
                                        Individual = new Individual()
                                        {
                                            IndividualID = 0,
                                            IndividualFirstName = txtStudentFirstName.Text,
                                            IndividualSecondName = txtStudentSecondName.Text,
                                            IndividualLastname = txtStudentLastname.Text,
                                            TitleID = Convert.ToInt32(cboStudentTitle.SelectedValue),

                                        }
                                    };

                                    Dbconnection.Students.Add(NewStudent);
                                    Dbconnection.SaveChanges();
                                    CurrentStudentID = NewStudent.StudentID;
                                    //CurrentSelectedStudent = NewStudent;

                                    if (StudentPictureToUploaded.Count > 0)
                                    {
                                        Data.Models.File f = StudentPictureToUploaded.FirstOrDefault<Data.Models.File>();
                                        Dbconnection.Files.Add(f);
                                        Dbconnection.SaveChanges();

                                        Dbconnection.StudentPhotos.Add(new StudentPhoto()
                                        {
                                            FileID = f.FileID,
                                            StudentID = CurrentStudentID,
                                            DateUpdated = DateTime.Now,
                                            StudentPhotoID = 0
                                        });
                                        Dbconnection.SaveChanges();
                                    }


                                    StudentObj = NewStudent;
                                    StudentObj.ObjectState = EntityObjectState.Modified;
                                    IsClosingPrematurly = false;
                                }

                            }

                            if (StudentObj.ObjectState == EntityObjectState.Modified)
                            {
                                Dbconnection.Students.Attach(StudentObj);
                                StudentObj.Individual.IndividualFirstName = txtStudentFirstName.Text;
                                StudentObj.Individual.IndividualSecondName = txtStudentSecondName.Text;
                                StudentObj.Individual.IndividualLastname = txtStudentLastname.Text;
                                StudentObj.Individual.TitleID = Convert.ToInt32(cboStudentTitle.SelectedValue);
                                StudentObj.StudentIDNumber = txtStudentIDNumber.Text.ToString();
                                StudentObj.EthnicityID = Convert.ToInt32(cboStudentEthnicity.SelectedValue);
                                StudentObj.GenderID = Convert.ToInt32(cboStudentGender.SelectedValue);
                                StudentObj.MartialStatusID = Convert.ToInt32(cboStudentMartialStatus.SelectedValue);
                                StudentObj.QualificationLevelID = Convert.ToInt32(cboStudentHighestQualificationLevel.SelectedValue);

                                Dbconnection.Entry(StudentObj).State = System.Data.Entity.EntityState.Modified;
                                Dbconnection.SaveChanges();
                            }

                            StudentObj.ObjectState = EntityObjectState.Modified;
                        };
                        CurrentSelectedStudent = StudentObj;
                        studentBindingSource.DataSource = StudentObj;
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
                        bRtn = false;
                    }
                    //studentBindingSource.ResetCurrentItem();
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
            if (studentBindingSource.List.Count == 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    //Dbconnection.Configuration.ProxyCreationEnabled = false;
                    Student StudentObj = (from a in Dbconnection.Students
                                          where a.StudentID == CurrentStudentID
                                          select a)
                                                       .Include(a => a.Individual)
                                                       //.Include(a => a.StudentPhotos)
                                                       .FirstOrDefault<Student>();
                    if (StudentObj == null)
                    {
                        StudentObj = new Student()
                        {
                            StudentID = 0,
                            ObjectState = EntityObjectState.Added,
                            Individual = new Individual()
                            {
                                IndividualID = 0,
                                ObjectState = EntityObjectState.Added
                            }
                        };
                    }
                    else
                    {
                        txtStudentFirstName.Text = StudentObj.Individual.IndividualFirstName;
                        txtStudentSecondName.Text = StudentObj.Individual.IndividualSecondName;
                        txtStudentLastname.Text = StudentObj.Individual.IndividualLastname;
                        txtStudentIDNumber.Text = StudentObj.StudentIDNumber.ToString();
                        cboStudentTitle.SelectedValue = StudentObj.Individual.TitleID;
                        cboStudentEthnicity.SelectedValue = StudentObj.EthnicityID;
                        cboStudentGender.SelectedValue = StudentObj.GenderID;
                        cboStudentMartialStatus.SelectedValue = StudentObj.MartialStatusID;
                        cboStudentHighestQualificationLevel.SelectedValue = StudentObj.QualificationLevelID;
                        StudentObj.ObjectState = EntityObjectState.Modified;
                        LoadStudentPictureFromDataBase();
                        ShowStudentPicture();
                        switchStudentPictureButtons();
                        IsClosingPrematurly = false;
                    }
                    studentBindingSource.DataSource = StudentObj;

                };
                switchStudentPictureButtons();

                txtStudentNumber.Focus();
            }
        }

        private void loadupStepTwo()
        {
            refreshStudentIDDocumnets();
        }

        private void loadupStepThree()
        {



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

        private void frmStudentAddUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClosingPrematurly)
            {
                DialogResult Rtn = MessageBox.Show("Process incomplete, do you wish to save the change made so far?", "Warning Form Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (Rtn == DialogResult.Yes)
                {
                    if (!this.ValidateStep())
                    {
                        e.Cancel = true;
                    }
                }
                if (Rtn == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void btnAddStudentIDDocuments_Click(object sender, EventArgs e)
        {
            
            List<Data.Models.File> StudentIDDocumentsToUploaded = FileHandeling.UploadFile(
                UseMultipleFileSelect: true,
                AutomaicallyAddFileToDatabase: false,
                ImagesOnly: false);

            if (StudentIDDocumentsToUploaded.Count > 0)
            {

                using (var Dbconnection = new MCDEntities())
                {

                    foreach (Data.Models.File f in StudentIDDocumentsToUploaded)
                    {
                        Dbconnection.StudentIDDocuments.Add(new StudentIDDocument()
                        {
                            FileID = f.FileID,
                            StudentID = this.CurrentStudentID,
                            File = f
                        });
                        Dbconnection.SaveChanges();
                    }
                };
                this.refreshStudentIDDocumnets();
                
            }
        }

        private void btnRemoveStudentIDDocuments_Click(object sender, EventArgs e)
        {
            DialogResult Rtn = MessageBox.Show("Are You Sure You Wish To Remove This File?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rtn == DialogResult.Yes)
            {
                Data.Models.File FileToRemove = (Data.Models.File)fileStudentIDDocumentBindingSource.Current;

                using (var Dbconnection = new MCDEntities())
                {
                    //Data.Models.File x = (from a in Dbconnection.Files
                    //                      where a.)
                    List<StudentIDDocument> x = (from a in Dbconnection.StudentIDDocuments
                                                 where a.FileID == FileToRemove.FileID
                                                 select a).ToList<StudentIDDocument>();
                    foreach(StudentIDDocument doc in x)
                    {
                        Dbconnection.Entry(doc).State = EntityState.Deleted;
                    } 
                    
                    Dbconnection.SaveChanges();
                };
                this.refreshStudentIDDocumnets();
            }

        }

        private void dgvStudentIDDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {

                case 0:


                    var FileObj = fileStudentIDDocumentBindingSource.Current;
                    Data.Models.File x = new Data.Models.File();
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
                            Data.Models.File CurrentFile = FileHandeling.GetFile(x.FileID);
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

    }
}
