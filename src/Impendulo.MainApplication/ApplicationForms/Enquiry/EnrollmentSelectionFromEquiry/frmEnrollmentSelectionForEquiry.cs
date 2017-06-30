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
using MetroFramework.Forms;

namespace Impendulo.Enquiry.Deployment.EnrollmentSelectionFromEquiry
{
    public partial class frmEnrollmentSelectionForEquiry : MetroForm
    {

        public int SelectedCurriculumEnquiryID { get; set; }
        public int SelectedEnrollmentID { get; set; }
        public Employee CurrentEmployeeLoggedIn { get; set; }
        public frmEnrollmentSelectionForEquiry()
        {
            InitializeComponent();
            SelectedCurriculumEnquiryID = 0;
            SelectedEnrollmentID = 0;
        }

        private void frmEnrollmentSelectionForEquiry_Load(object sender, EventArgs e)
        {
            populateEquiryEnrollments();
        }

        private void populateEquiryEnrollments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                var result = (from a in Dbconnection.Enrollments
                              from b in a.CurriculumEnquiries
                              where b.CurriculumEnquiryID == this.SelectedCurriculumEnquiryID
                              //&& a.LookupEnrollmentProgressStateID == (int)Common.Enum.EnumEnrollmentProgressStates.In_Progress
                              select a)
                                                        .Include("Student")
                                                        .Include("Student.Individual")
                                                        .Include("Curriculum")
                                                        .Include("LookupEnrollmentProgressState")
                                                        .ToList<Enrollment>();
                enrollmentBindingSource.DataSource = result;
            };
        }

        private void enrollmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    SelectedEnrollmentID = ((Enrollment)enrollmentBindingSource.Current).EnrollmentID;
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void enrollmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {

                    Enrollment EnrollmentObj = (Enrollment)(row.DataBoundItem);

                    row.Cells[colStudentIDNumber.Index].Value = EnrollmentObj.Student.StudentIDNumber.ToString();
                    row.Cells[colFirstName.Index].Value = EnrollmentObj.Student.Individual.IndividualFirstName.ToString();
                    row.Cells[colLastName.Index].Value = EnrollmentObj.Student.Individual.IndividualLastname.ToString();
                    row.Cells[colStatus.Index].Value = EnrollmentObj.LookupEnrollmentProgressState.EnrollmentProgressCurrentState.ToString();
                }
            }
        }
    }
}

