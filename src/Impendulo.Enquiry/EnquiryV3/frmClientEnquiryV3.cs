using Impendulo.Common.Enum;
using Impendulo.ContactDetails.Development;
using Impendulo.Data.Models;
using Impendulo.Email.Email_Message_Version_2;
using Impendulo.Enquiry.Development.InitaialConsultation;
using Impendulo.Enquiry.Development.SearchForSelectedEnquiry;
using Impendulo.Enquiry.Development.ViewHistory;
using Impendulo.Enquiry.SelectContacts.Deployment1;
using Impendulo.Enquiry.SelectContacts.Developemnt;
using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress;
using Impendulo.WizardForm.ClientEnquiry.Development;
using MetroFramework;
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

namespace Impendulo.Enquiry.Development.EnquiryV3
{
    public partial class frmClientEnquiryV3 : MetroFramework.Forms.MetroForm
    {

        //Form Properties
        public Employee CurrentEmployeeLoggedIn { get; set; }

        private int _CurrentSelectedEnquiryID = 0;
        public int CurrentSelectedEnquiryID
        {
            get { return _CurrentSelectedEnquiryID; }
            set { _CurrentSelectedEnquiryID = value; }
        }
        public frmClientEnquiryV3()
        {
            InitializeComponent();
            //Remove before deploying
            // _CurrentSelectedEnquiryID = 7184;
        }

        private void frmClientEnquiryV3_Load(object sender, EventArgs e)
        {
            if (CurrentEmployeeLoggedIn == null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEmployeeLoggedIn = (from a in Dbconnection.Employees
                                               where a.EmployeeID == 11075
                                               select a)
                                               .Include("LookupDepartments")
                                               .FirstOrDefault<Employee>();
                };
            }
            //Loads up the Currently Selected Equiry - Is Blank.
            this.refreshInProgressEnquiry(_CurrentSelectedEnquiryID);
            this.disableFormControlsIfNoEnquiryLoaded();
        }

        #region Inprogress Enquiry

        #region Refresh Methods
        private void refreshInProgressEnquiry(int EnquiryID)
        {
            this.populateInprogressEnquiry(EnquiryID);
        }
        #endregion

        #region Populate Methods

        private void populateInprogressEnquiry(int _EnquiryID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                Data.Models.Enquiry x = (from a in Dbconnection.Enquiries
                                         where a.EnquiryID == _EnquiryID
                                         select a)
                                         .Include("Individuals")
                                         .Include("Individuals.ContactDetails")
                                         .Include("Individuals.ContactDetails.LookupContactType")
                                          .Include("CurriculumEnquiries")
                                          .Include("CurriculumEnquiries.Curriculum")
                                          .Include("Companies")
                                          .FirstOrDefault<Data.Models.Enquiry>();



                if (x != null)
                {
                    ////filter out closed enquiries.
                    List<CurriculumEnquiry> DataSourceList;

                    DataSourceList = new List<CurriculumEnquiry>();
                    foreach (CurriculumEnquiry CE in x.CurriculumEnquiries)
                    {
                        if (CE.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed && DetermineIfPartOfDepartment(CE.Curriculum.DepartmentID))
                        {
                            DataSourceList.Add(CE);
                        }
                    }
                    x.CurriculumEnquiries.Clear();
                    foreach (CurriculumEnquiry CE in DataSourceList)
                    {
                        x.CurriculumEnquiries.Add(CE);
                    }
                    //FilteredListWithNoCurriculumEnquiryItemsListed = (from a in FilteredListWithNoCurriculumEnquiryItemsListed
                    //                                                  orderby a.EnquiryID descending
                    //                                                  select a).ToList<Data.Models.Enquiry>();
                    //NewEnquiryTab_NewEnquiryBindingSource.DataSource = FilteredListWithNoCurriculumEnquiryItemsListed;
                    //
                    enquiryInprogressBindingSource.DataSource = x;
                }

            };
        }
        #endregion
        #region Control Event Methods
        private void btnAddContactDetail_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails())
            {
                Individual CurrentContact = (Individual)((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Individuals.FirstOrDefault<Individual>();

                frm.ShowDialog();
                if (frm.CurrentDetail != null)
                {
                    using (var Dbconnection = new MCDEntities())
                    {

                        Dbconnection.Individuals.Attach(CurrentContact);

                        ContactDetail Con = new ContactDetail
                        {
                            ContactTypeID = frm.CurrentDetail.ContactTypeID,
                            ContactDetailValue = frm.CurrentDetail.ContactDetailValue
                        };

                        Dbconnection.ContactDetails.Attach(frm.CurrentDetail);

                        Dbconnection.Entry(frm.CurrentDetail).Reference(a => a.LookupContactType).Load();
                        CurrentContact.ContactDetails.Add(frm.CurrentDetail);

                        Dbconnection.SaveChanges();



                    };
                    // refreshInProgressEnquiry(CurrentSelectedEnquiryID);
                }
            }
        }

        private void btnRemoveContactDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnuUpdateContactDetails_Click(object sender, EventArgs e)
        {

        }
        private void enquiryInprogressBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Data.Models.Enquiry EnquiryObj = (Data.Models.Enquiry)(enquiryInprogressBindingSource.Current);
            if (EnquiryObj != null)
            {

                if (EnquiryObj.Companies.Count == 0)
                {
                    txtInprogressCompanyName.Text = "NA - Private Enquiry";
                }
            }
        }
        private void dgvInprogressContactDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ContactDetailObj = (ContactDetail)(row.DataBoundItem);
                    row.Cells[colInProgressContactType.Index].Value = ContactDetailObj.LookupContactType.ContactType.ToString();
                    if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address)
                    {
                        row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send Email ]";
                    }
                    if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Cell_Number)
                    {
                        row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send SMS ]";
                    }
                }
            }
        }


        private void btnSearchForEnquiry_Click(object sender, EventArgs e)
        {
            using (frmSearchForSelectedEquiry frm = new frmSearchForSelectedEquiry())
            {
                frm.ShowDialog();
                this.refreshInProgressEnquiry(frm.SelectedEnquiryID);
                if (enquiryInprogressBindingSource.Count > 0)
                {
                    this.enableFormControlsIfNoEnquiryLoaded();
                }
                else
                {
                    this.disableFormControlsIfNoEnquiryLoaded();
                }
            }
        }

        private void dgvInprogressContactDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;

            if (e.ColumnIndex == 2)
            {
                var ContactDetailObj = (ContactDetail)(gridView.Rows[e.RowIndex].DataBoundItem);
                if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address)
                {
                    using (frmEmailMessageV2 frm = new frmEmailMessageV2())
                    {
                        frm.txtMessageSubject.Text = "MCD Communication - Follow On Enquiry - " + txtEnquiryInProgressEnquiryID.Text;
                        frm.txtMessageSubject.ReadOnly = true;
                        frm.ShowDialog();


                    }
                }
            }
        }
        private void btnInitialConsultationConfirmation_Click(object sender, EventArgs e)
        {
            if (!(((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).InitialConsultationComplete))
            {
                using (frmEnquiryInitialConsultationV2 frm = new frmEnquiryInitialConsultationV2())
                {
                    frm.EmployeeID = CurrentEmployeeLoggedIn.EmployeeID;
                    frm.CurrentEnquiry = (Data.Models.Enquiry)enquiryInprogressBindingSource.Current;
                    frm.ShowDialog();
                    this.enquiryInprogressBindingSource.ResetCurrentItem();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Initial Consultaion is completed, See History for details.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void enquiryDateTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            x.Text = Convert.ToDateTime(x.Text).ToString("D");
        }
        #endregion

        #region Form Logic Control Flow Methods
        private Boolean DetermineIfPartOfDepartment(int DepartmentIdToCheck)
        {
            Boolean IsPart = false;
            foreach (LookupDepartment EmployDep in CurrentEmployeeLoggedIn.LookupDepartments)
            {
                if (EmployDep.DepartmentID == DepartmentIdToCheck)
                {
                    IsPart = true;
                }
            }

            return IsPart;

        }
        private void disableFormControlsIfNoEnquiryLoaded()
        {
            btnViewProgressInProgressSections.Visible = false;
            btnInitialConsultationConfirmationInProgressSection.Visible = false;
            btnCloseInprogressEnquiry.Visible = false;
            gbInprogressContactNameAndCompanyName.Enabled = false;
            gbInProgressContactDetails.Enabled = false;
            gbInProgressEnquiryEnrrolmentQueries.Enabled = false;
        }
        private void enableFormControlsIfNoEnquiryLoaded()
        {
            btnViewProgressInProgressSections.Visible = true;
            btnInitialConsultationConfirmationInProgressSection.Visible = true;
            btnCloseInprogressEnquiry.Visible = true;
            gbInprogressContactNameAndCompanyName.Enabled = true;
            gbInProgressContactDetails.Enabled = true;
            gbInProgressEnquiryEnrrolmentQueries.Enabled = true;
        }







        #endregion

        #endregion

        private void btnViewProgressInProgressSections_Click(object sender, EventArgs e)
        {
            using (frmEquiryViewHistoryV2 frm = new frmEquiryViewHistoryV2())
            {
                frm.EnquiryID = Convert.ToInt32(txtEnquiryInProgressEnquiryID.Text);
                frm.ShowDialog();
            }
        }

        private void btnInProgressSwitchBetweenCompanyANdPrivate_Click(object sender, EventArgs e)
        {
            if (((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Companies.Count == 0)
            {
                using (frmSelectCompanyContact frm = new frmSelectCompanyContact())
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                //Selects From List Of All Students from the Custom Student Search Form
                using (frmSelectIndividualContact frm = new frmSelectIndividualContact())
                {
                    frm.ShowDialog();
                    //get the Individual Selected Which represents the Student Selected.

                    if (frm.SelectedIndividual != null)
                    {

                        using (var Dbconnection = new MCDEntities())
                        {
                            /*1. Removes the current Slected Company Contact*/
                            Data.Models.Enquiry CurrentEnquiry = ((Data.Models.Enquiry)enquiryInprogressBindingSource.Current);

                            Dbconnection.Enquiries.Attach(CurrentEnquiry);

                            List<Individual> temp = ((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Individuals.ToList<Individual>();
                            List<Data.Models.Company> tempCompanies = ((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Companies.ToList<Data.Models.Company>();
                            foreach (Individual individ in temp)
                            {
                                ((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Individuals.Remove(individ);
                            }
                            foreach (Data.Models.Company comp in tempCompanies)
                            {
                                ((Data.Models.Enquiry)enquiryInprogressBindingSource.Current).Companies.Remove(comp);
                            }
                            // Dbconnection.Entry(CurrentEnquiry).State = EntityState.Modified;
                            Dbconnection.SaveChanges();
                            /*1. End Removal of Current Enquiry Contact*/


                            /*2. Adds The Cuurentlty Selected Student Contact to be linked with the Enquiry for future contacting*/
                            Individual IndividualToLink = (from a in Dbconnection.Individuals
                                                           where a.IndividualID == frm.SelectedIndividual.IndividualID
                                                           select a).FirstOrDefault<Individual>();
                            CurrentEnquiry.Individuals.Add(IndividualToLink);
                            Dbconnection.SaveChanges();
                            /*2. End Adding the Student Contact Details To the Enquiry.*/
                        };
                    }
                    this.refreshInProgressEnquiry(CurrentSelectedEnquiryID);


                }
            }
        }

        private void dgvInProgressCurriculumEnquiries_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumEnquiryObj = (CurriculumEnquiry)(row.DataBoundItem);
                    row.Cells[colInProgressCurriculumName.Index].Value = CurriculumEnquiryObj.Curriculum.CurriculumName.ToString();
                    row.Cells[colInProgressEnquiryQuantityCurrentlyEnrolled.Index].Value = "0";


                    //if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Email_Address)
                    //{
                    //    row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send Email ]";
                    //}
                    //if (ContactDetailObj.ContactTypeID == (int)Common.Enum.EnumContactTypes.Cell_Number)
                    //{
                    //    row.Cells[colInProgressContactDetailSendOption.Index].Value = "[ Send SMS ]";
                    //}
                }
            }
        }

        private void dgvInProgressCurriculumEnquiries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CurriculumEnquiry CE = (CurriculumEnquiry)dgvInProgressCurriculumEnquiries.Rows[e.RowIndex].DataBoundItem;
            switch (e.ColumnIndex)
            {
                case 5:
                    if (CE.Curriculum.DepartmentID == (int)EnumDepartments.Apprenticeship)
                    {

                        using (var Dbconnection = new MCDEntities())
                        {
                            Dbconnection.CurriculumEnquiries.Attach(CE);
                            Dbconnection.Entry(CE).Collection(a => a.Enrollments).Load();
                              //.Include("CurriculumEnquiries.Enrollments")
                        };
                        if (CE.EnrollmentQuanity >= CE.Enrollments.Count)
                        {
                            frmApprenticeshipEnrollmentFormV2 frm6 = new frmApprenticeshipEnrollmentFormV2();
                            frm6.CurrentCurriculumEnquiry = CE;
                            // curriculumEnquiriesBindingSource.ResetItem(e.RowIndex);
                            frm6.ShowDialog();
                            //Check to see if the amoount required to be enrolled equal the amount that have been enrolled.
                            //if (CE.EnrollmentQuanity <= CE.Enrollments.Count)
                            //{
                            //    using (var Dbconnection = new MCDEntities())
                            //    {
                            //        Dbconnection.CurriculumEnquiries.Attach(CE);
                            //        CE.EnquiryStatusID = (int)EnumEnquiryStatuses.Enquiry_Closed;
                            //        CE.LastUpdated = DateTime.Now;
                            //        Dbconnection.Entry<CurriculumEnquiry>(CE).State = System.Data.Entity.EntityState.Modified;
                            //        Dbconnection.SaveChanges();
                            //        Dbconnection.CurriculumEnquiries.Remove(CE);
                            //        int currentIndex = NewEnquiryTab_NewEnquiryBindingSource.Position;
                            //        refreshNewEnquiry();
                            //        NewEnquiryTab_NewEnquiryBindingSource.Position = currentIndex;
                            //        dgvNewEnquiryTab_CurriculumEnquiry.Refresh();

                            //    };
                            //}
                            DialogResult Rtn1 = MessageBox.Show("Do you wish to View the Enrollment,and course selection?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (Rtn1 == DialogResult.Yes)
                            {
                                using (frmEnrolmmentInprogress frm = new frmEnrolmmentInprogress())
                                {
                                    frm.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;
                                    frm.CurrentSelectedDepartment = (Common.Enum.EnumDepartments)CE.Curriculum.DepartmentID;
                                    // frmStudentCourseEnrollmentV2 frm7 = new frmStudentCourseEnrollmentV2();
                                    frm.ShowDialog();
                                }


                            }
                        }

                    }
                    break;
            }
        }
    }
}
