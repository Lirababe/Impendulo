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

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.ScheduleApprientice
{
    public partial class frmScheduleApprience : MetroForm
    {
        public int _EnrolmentID { get; set; }

        public frmScheduleApprience()
        {
            InitializeComponent();
        }

        private void frmScheduleApprience_Load(object sender, EventArgs e)
        {
            populateCoursesToBeScheduled();
        }

        //refresh Method
        private void refreshEnrollment()
        {
            //EnrollmentInprogress.frmEnrolmmentInprogress frm = new EnrollmentInprogress.frmEnrolmmentInprogress();
            //if (frm.enrollmentBindingSource.List.Count > 0)
            //{
            //    refreshScheduleCoursePriliminaryDate();
            //}
        }

        private void refreshScheduleCoursePriliminaryDate()
        {
            //int _EnrollmentID = 0;
            //EnrollmentInprogress.frmEnrolmmentInprogress frm = new EnrollmentInprogress.frmEnrolmmentInprogress();
            //if (frm.enrollmentBindingSource.List.Count > 0)
            //{
            //    _EnrollmentID = ((Enrollment)(frm.enrollmentBindingSource.Current)).EnrollmentID;
            //}
            //populateCoursesToBeScheduled();

        }

        //populate methods
        private void populateCoursesToBeScheduled()
        {
            using (var Dbconnection = new MCDEntities())
            {
                ScheduleApprienticeshipbindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                  from b in a.CurriculumCourseEnrollments
                                                                  where b.EnrollmentID == _EnrolmentID
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

        DateTimePicker dtp = new DateTimePicker();
        private void mdgvScheduleApprienticeship_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dtp = new DateTimePicker();
                mdgvScheduleApprienticeship.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Short;
                Rectangle Rectangle = mdgvScheduleApprienticeship.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
                dtp.Location = new Point(Rectangle.X, Rectangle.Y);

                dtp.CloseUp += new EventHandler(dtp_CloseUp);
                dtp.TextChanged += new EventHandler(dtp_OnTextChange);


                dtp.Visible = true;
            }
        }
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            mdgvScheduleApprienticeship.CurrentCell.Value = dtp.Text.ToString();
        }
        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }
    }
}
