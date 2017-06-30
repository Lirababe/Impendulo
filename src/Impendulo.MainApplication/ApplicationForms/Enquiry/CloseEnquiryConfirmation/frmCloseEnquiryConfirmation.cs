using Impendulo.Common.Enum;
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

namespace Impendulo.Enquiry.Deployment.CloseEnquiryConfirmation
{
    public partial class frmCloseEnquiryConfirmation : MetroForm
    {

        public Data.Models.Enquiry CurrentSelectedEnquiry { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }

        public Boolean IsSuccessfullyClosedOff { get; set; }
        public frmCloseEnquiryConfirmation()
        {
            IsSuccessfullyClosedOff = false;
            InitializeComponent();
        }

        private void frmCloseEnquiryConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {


                Dbconnection.Enquiries.Attach(CurrentSelectedEnquiry);
                foreach (CurriculumEnquiry CE in CurrentSelectedEnquiry.CurriculumEnquiries)
                {
                    CE.EnquiryStatusID = (int)EnumEnquiryStatuses.Enquiry_Closed;
                }
                CurrentSelectedEnquiry.EnquiryStatusID = (int)EnumEnquiryStatuses.Enquiry_Closed;
                Dbconnection.SaveChanges();


                string EnquiryClosedText = "None Reason Was Specified.";
                if (txtNotes.Text.Length > 0)
                {
                    EnquiryClosedText = txtNotes.Text;
                }
                EquiryHistory hist = new EquiryHistory
                {
                    EnquiryID = CurrentSelectedEnquiry.EnquiryID,
                    EmployeeID = this.CurrentEmployeeLoggedIn.EmployeeID,
                    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Equiry_Responded_And_Closed,
                    DateEnquiryUpdated = DateTime.Now,
                    EnquiryNotes = EnquiryClosedText
                };
                Dbconnection.EquiryHistories.Add(hist);
                Dbconnection.SaveChanges();
                IsSuccessfullyClosedOff = true;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
