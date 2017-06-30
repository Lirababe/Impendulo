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
using MetroFramework.Forms;
using Impendulo.Common.Enum;
using Impendulo.StudentEngineeringCourseErollment.Deployment.EnrollmentInprogress;

namespace Impendulo.StudentEngineeringCourseErollment.Deployment.ScheduleApprientice
{
    public partial class frmScheduleApprience : MetroForm
    {
        public frmScheduleApprience()
        {
            InitializeComponent();
        }

        private void frmScheduleApprience_Load(object sender, EventArgs e)
        {
            refreshEnrollment();
        }

        //refresh Method
        private void refreshEnrollment()
        {
            frmEnrolmmentInprogress frm = new frmEnrolmmentInprogress();
            if (frm.enrollmentBindingSource.List.Count > 0)
            {
                refreshScheduleCoursePriliminaryDate();
            }
        }

        private void refreshScheduleCoursePriliminaryDate()
        {
            int _EnrollmentID = 0;
            frmEnrolmmentInprogress frm = new frmEnrolmmentInprogress();
            if (frm.enrollmentBindingSource.List.Count > 0)
            {
                _EnrollmentID = ((Enrollment)(frm.enrollmentBindingSource.Current)).EnrollmentID;
            }
            populateCoursesToBeScheduled(_EnrollmentID);

        }

        //populate methods
        private void populateCoursesToBeScheduled(int _EnrollmentID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                ScheduleApprienticeshipbindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                  from b in a.CurriculumCourseEnrollments
                                                                  where b.EnrollmentID == _EnrollmentID
                                                                  select a).ToList<CurriculumCourse>();
            };
        }

        private void mdgvScheduleApprienticeship_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colCourses.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                    
                }
            }
        }
    }
}
