using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Enquiry.Development.EnrollmentSelectionFromEquiry
{
    public partial class frmEnrollmentSelectionForEquiry : Form
    {

        public int SelectedCurriculumEnquiryID { get; set; }
        public int SelectedEnrollmentID { get; set; }
        public frmEnrollmentSelectionForEquiry()
        {
            InitializeComponent();
            SelectedCurriculumEnquiryID = 0;
            SelectedEnrollmentID = 0;
        }

        private void frmEnrollmentSelectionForEquiry_Load(object sender, EventArgs e)
        {

        }

        private void populateEquiryEnrollments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                enrollmentBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                      from b in a.CurriculumEnquiries
                                                      where b.CurriculumEnquiryID == this.SelectedCurriculumEnquiryID
                                                      select a)
                                                      .Include("Student")
                                                      .Include("Curriculum")
                                                      .Include("LookupEnrollmentProgressState")
                                                      .ToList<Enrollment>();
            };
        }

        private void enrollmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    SelectedEnrollmentID = ((Enrollment)enrollmentBindingSource.Current).EnrollmentID;
                    break;
                default:
                    break;
            }
        }
    }
}

