using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.CoursesRedevelopment.Course_Configuration_Form.Update_Course_Components
{
    public partial class frmUpdateCurriculumCourseV2 : MetroFramework.Forms.MetroForm
    {
        public int CurriculumCourseID { get; set; }
        public frmUpdateCurriculumCourseV2()
        {
            CurriculumCourseID = 0;
            InitializeComponent();
        }

        private void frmUpdateCurriculumCourseV2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
