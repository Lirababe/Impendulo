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

namespace Impendulo.Enquiry.Development.InitaialConsultation
{
    public partial class frmEnquiryInitialConsultationV2 : MetroForm
    {
        public int EmployeeID { get; set; }
        public Data.Models.Enquiry CurrentEnquiry { get; set; }
        public frmEnquiryInitialConsultationV2()
        {
            InitializeComponent();
        }

        private void frmEnquiryInitialConsultationV2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                EquiryHistory hist = new EquiryHistory
                {
                    EnquiryID = CurrentEnquiry.EnquiryID,
                    EmployeeID = this.EmployeeID,
                    LookupEquiyHistoryTypeID = (int)EnumEquiryHistoryTypes.Enquiry_Initial_Consultation_Completed,
                    DateEnquiryUpdated = DateTime.Now,
                    EnquiryNotes = txtNotes.Text
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
