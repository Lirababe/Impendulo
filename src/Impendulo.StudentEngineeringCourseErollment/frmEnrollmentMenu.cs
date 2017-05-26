using Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentInprogress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment
{
    public partial class frmEnrollmentMenu : Form
    {
        public frmEnrollmentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEnrolmmentInprogress frm = new frmEnrolmmentInprogress();
            frm.ShowDialog();
        }

        private void frmEnrollmentMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
