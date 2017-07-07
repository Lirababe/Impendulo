using Impendulo.Courses.Development.LinkCurriculumCourseWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.CoursesRedevelopment
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmAddCurriculumCourseV2 frm = new frmAddCurriculumCourseV2())
            {
                frm.ShowDialog();
            }
        }
    }
}
