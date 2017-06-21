using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using Impendulo.Email.Email_Message_Version_2;
using Impendulo.Enquiry.Development.InitaialConsultation;
using Impendulo.Enquiry.Development.SearchForSelectedEnquiry;
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
                                          .Include("CurriculumEnquiries")
                                          .Include("Companies")
                                          .FirstOrDefault<Data.Models.Enquiry>();



                if (x != null)
                {
                    ////filter out closed enquiries.
                    List<CurriculumEnquiry> DataSourceList;

                    DataSourceList = new List<CurriculumEnquiry>();
                    foreach (CurriculumEnquiry CE in x.CurriculumEnquiries)
                    {
                        if (CE.EnquiryStatusID != (int)EnumEnquiryStatuses.Enquiry_Closed)
                        {
                            DataSourceList.Add(CE);
                        }
                    }
                    x.CurriculumEnquiries.Clear();
                    foreach (CurriculumEnquiry CE in DataSourceList)
                    {
                        x.CurriculumEnquiries.Add(CE);
                    }

                    enquiryInprogressBindingSource.DataSource = x;
                }

            };
        }
        #endregion
        #region Control Event Methods
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
                        frm.ShowDialog();
                    }
                }
            }
        }
        private void btnInitialConsultationConfirmation_Click(object sender, EventArgs e)
        {
            using (frmEnquiryInitialConsultationV2 frm = new frmEnquiryInitialConsultationV2())
            {
                frm.EmployeeID = CurrentEmployeeLoggedIn.EmployeeID;
                frm.CurrentEnquiry = (Data.Models.Enquiry)enquiryInprogressBindingSource.Current;
                frm.ShowDialog();
                this.enquiryInprogressBindingSource.ResetCurrentItem();
            }
        }

        private void enquiryDateTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            x.Text = Convert.ToDateTime(x.Text).ToString("D");
        }
        #endregion

        #region Form Logic Control Flow Methods
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








    }
}
