using Impendulo.Email.Development;
using Impendulo.Email.Reseach;
using Impendulo.Email.Select_Contacts.Development;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Email
{
    public partial class frmEmailMenu : Form
    {
        public frmEmailMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSelectEmailContacts frm = new frmSelectEmailContacts();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSendEmail frm = new frmSendEmail();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmailTestONe frm = new EmailTestONe();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
