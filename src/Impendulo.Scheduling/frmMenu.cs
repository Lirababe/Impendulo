using Impendulo.Scheduling.Development.AllCourses;
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

namespace Impendulo.Scheduling.Development
{
    public partial class frmMenu : MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (frmScheduleCurriculumCourses frm = new frmScheduleCurriculumCourses())
            {
                frm.ShowDialog();
            }
        }
    }
}
