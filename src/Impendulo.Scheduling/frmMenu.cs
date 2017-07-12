using Impendulo.Scheduling.Development.AllCourses;
using Impendulo.Scheduling.Development.PreCalculations;
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            using( frmPreCalculationTest frm = new frmPreCalculationTest())
            {
                frm.ShowDialog();
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //using (frmClientEnquiryV3 frm = new frmClientEnquiryV3())
            //{
            //    frm.ShowDialog();
            //}
        }
    }
}
