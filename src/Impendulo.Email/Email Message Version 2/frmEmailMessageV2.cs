using Impendulo.Email.Select_Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Impendulo.Email.Email_Message_Version_2
{
    public partial class frmEmailMessageV2 : MetroFramework.Forms.MetroForm
    {

        public List<string> AttachmentsUsingFilePaths { get; set; }

        public Boolean IsSent { get; set; }

        public frmEmailMessageV2()
        {
            InitializeComponent();
        }

        private void frmEmailMessageV2_Load(object sender, EventArgs e)
        {
            this.IsSent = false;
            //this.refreshAttachemntListUsingDatabaseFileID();
            //this.refreshTheAttachmentList();
        }
        #region Control Click Events
        private void btnToAddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
            }
        }

        private void btnCCAddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
            }
        }

        private void btnBCCddress_Click(object sender, EventArgs e)
        {
            using (frmSelectEmailContsV2 frm = new frmSelectEmailContsV2())
            {
                frm.ShowDialog();
            }
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
