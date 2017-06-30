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

namespace Impendulo.Enquiry.Deployment.InitaialConsultation
{
    public partial class frmEnquiryInitialConsultation : MetroForm
    {
        public int EmployeeID { get; set; }
        public Data.Models.Enquiry CurrentEnquiry { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }
        public frmEnquiryInitialConsultation()
        {
            InitializeComponent();
        }

        private void frmEnquiryInitialConsultation_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                string InitialConsultationText = "None or No Notes where documented.";
                if (txtNotes.Text.Length > 0)
                {
                    InitialConsultationText = txtNotes.Text;
                }
                EquiryHistory hist = new EquiryHistory
                {
                    EnquiryID = CurrentEnquiry.EnquiryID,
                    EmployeeID = this.EmployeeID,
                    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Initial_Consultation_Completed,
                    DateEnquiryUpdated = DateTime.Now,
                    EnquiryNotes = InitialConsultationText
                };
                Dbconnection.EquiryHistories.Add(hist);
                int IsSaved = Dbconnection.SaveChanges();
                if (IsSaved > 0)
                {
                    Dbconnection.Enquiries.Attach(CurrentEnquiry);
                    CurrentEnquiry.InitialConsultationComplete = true;
                    Dbconnection.Entry<Data.Models.Enquiry>(CurrentEnquiry).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                }
            };
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
