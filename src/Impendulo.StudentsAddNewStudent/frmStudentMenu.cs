using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Development.Students
{
    public partial class frmStudentMenu : Form
    {
        public frmStudentMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmStudentAddUpdate frm = new frmStudentAddUpdate())
            {
                frm.ShowDialog();
            }
        }
    }
}
