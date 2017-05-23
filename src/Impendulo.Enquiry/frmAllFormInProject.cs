using Impendulo.Enquiry.Development.EnquiryV2.Development;
using Impendulo.Enquiry.Development.InitaialConsultation;
using Impendulo.Enquiry.Development.InitialDocumentation.ApprenticeshipDocumentation;
using Impendulo.Enquiry.Development.ViewHistory;
using Impendulo.Enquiry.Development.WorkBanchEnquiries;
using Impendulo.Enquiry.SelectContacts.Deployment1;
using Impendulo.Enquiry.SelectContacts.Developemnt;
using Impendulo.Enquiry.SelectCourseCurriculum.Development;
using Impendulo.Enquiry.ViewContactInformation.Development;
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

        private void button5_Click(object sender, EventArgs e)
        {
            frmSelectCompanyContact frm = new frmSelectCompanyContact();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSelectIndividualContact frm = new frmSelectIndividualContact();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSelectCourseCurriculumForClientEnquiry frm = new frmSelectCourseCurriculumForClientEnquiry();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmEnquiryViewContactInformation frm = new frmEnquiryViewContactInformation();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmEnquiryViewHistory frm = new frmEnquiryViewHistory();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmWorkbanchEnquiries frm = new frmWorkbanchEnquiries();
            frm.ShowDialog();
        }

        private void frmAllFormInProject_Load(object sender, EventArgs e)
        {

        }
        //
        //frmSelectCompanyContact
    }
}
