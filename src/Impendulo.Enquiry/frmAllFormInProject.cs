using Impendulo.Enquiry.Development.EnquiryV2.Development;
using Impendulo.Enquiry.Development.InitaialConsultation;
using Impendulo.Enquiry.Development.InitialDocumentation.ApprenticeshipDocumentation;
using Impendulo.WizardForm.ClientEnquiry.Development;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Enquiry.Development
{
    public partial class frmAllFormInProject : Form
    {
        public frmAllFormInProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientEnquiryV2 frm = new frmClientEnquiryV2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEnquiryInitialConsultation frm = new frmEnquiryInitialConsultation();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInitailDocumentation frm = new frmInitailDocumentation();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNewEnquiry frm = new frmNewEnquiry();
            frm.ShowDialog();
        }
    }
}
