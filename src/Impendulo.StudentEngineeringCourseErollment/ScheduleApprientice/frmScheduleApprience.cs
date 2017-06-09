using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Data.Models;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.ScheduleApprientice
{
    public partial class frmScheduleApprience : Form
    {
        public frmScheduleApprience()
        {
            InitializeComponent();
        }

        private void frmScheduleApprience_Load(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {

            }
        }

        private void dgvConfirmSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var Obj = (Facilitator)(row.DataBoundItem);
                    var Obj1 = (Venue)(row.DataBoundItem);
                    
                    row.Cells[colFacilitator.Index].Value = Obj.FacilitatorAssociatedCourses;
                    row.Cells[colVanue.Index].Value = Obj1.VenueName;
                    row.Cells[colMaximum.Index].Value = Obj1.VenueMaxCapacity;
                    //row.Cells[colNewEnquiry_Curriculum.Index].Value = CurriculumEnquiryObj.Curriculum.CurriculumName.ToString();
                }
            }
        }

        private void dgvConfirmSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
