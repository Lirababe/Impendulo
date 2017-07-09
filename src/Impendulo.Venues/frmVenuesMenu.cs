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

namespace Impendulo.Venues
{
    public partial class frmVenuesMenu : MetroForm
    {
        public frmVenuesMenu()
        {
            InitializeComponent();
        }

        private void frmVenuesMenu_Load(object sender, EventArgs e)
        {

        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (frmVenueAssociatedCourses frm = new frmVenueAssociatedCourses())
            {
                frm.ShowDialog();
            }
        }
    }
}
