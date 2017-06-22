using Impendulo.Contacts.Deployment;
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

namespace Impendulo.Development.Contacts
{
    public partial class frmMenuForForms : MetroForm
    {
        public frmMenuForForms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuForForms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmContactsV2 frm = new frmContactsV2())
            {
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmContacts frm = new frmContacts())
            {
                frm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (frmContactsV2 frm = new frmContactsV2())
            {
                frm.IsStudent = true;
                frm.ShowDialog();
            }
        }
    }
}
