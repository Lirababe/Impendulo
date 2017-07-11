using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.Entity;
namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.EnrollmentCourseSelection
{
    public partial class frmEnrollmentCourseSelection : MetroForm
    {
        public frmEnrollmentCourseSelection()
        {
            InitializeComponent();
            if (CurrentEnrollemnt == null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    CurrentEnrollemnt = (from a in Dbconnection.Enrollments
                                         .Include("CurriculumCourseEnrollments")
                                         .Include("CurriculumCourseEnrollments.CurriculumCourse")
                                         orderby a.DateIntitiated descending
                                         select a).FirstOrDefault<Enrollment>();
                };

            }

        }

        public Enrollment CurrentEnrollemnt { get; set; }

        private void frmEnrollmentCourseSelection_Load(object sender, EventArgs e)
        {
            populateLinkedCurriculumCourses();
            populateAvailableCurriculumCourses();

        }

        private void populateLinkedCurriculumCourses()
        {
            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseLinkedBindingSource.DataSource = (from a1 in Dbconnection.GetCurriculumCourseInOrder(CurrentEnrollemnt.CurriculumID)
                                                                  select a1).Intersect(from a2 in Dbconnection.CurriculumCourseEnrollments
                                                                                       where a2.EnrollmentID == CurrentEnrollemnt.EnrollmentID
                                                                                       select a2.CurriculumCourse)
                                                                  .ToList<CurriculumCourse>();

                foreach (CurriculumCourse CurriculumCourseObj in curriculumCourseLinkedBindingSource.List)
                {
                    if (!Dbconnection.Entry(CurriculumCourseObj).Reference(a => a.Course).IsLoaded)
                    {
                        Dbconnection.Entry(CurriculumCourseObj).Reference(a => a.Course).Load();
                    }
                    if (!Dbconnection.Entry(CurriculumCourseObj).Collection(a => a.CurriculumCourseEnrollments).IsLoaded)
                    {
                        Dbconnection.Entry(CurriculumCourseObj).Collection(a => a.CurriculumCourseEnrollments).Load();
                    }
                }
            };
        }

        private void populateAvailableCurriculumCourses()
        {
            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseAvailableBindingSource.DataSource = (from a in Dbconnection.GetCurriculumCourseInOrder(CurrentEnrollemnt.CurriculumID)
                                                                         // where a.CurriculumID == CurrentEnrollemnt.CurriculumID
                                                                     select a).Except(
                    from a in Dbconnection.CurriculumCourseEnrollments
                    where a.EnrollmentID == CurrentEnrollemnt.EnrollmentID
                    select a.CurriculumCourse
                    ).ToList();
                //curriculumCourseAvailableBindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                //                                                     where a.CurriculumID == CurrentEnrollemnt.CurriculumID
                //                                                     select a).Except(
                //   from a in Dbconnection.CurriculumCourseEnrollments
                //   where a.EnrollmentID == CurrentEnrollemnt.EnrollmentID
                //   select a.CurriculumCourse
                //   ).ToList();
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinkCourse_Click(object sender, EventArgs e)
        {
            List<CurriculumCourse> CC = new List<CurriculumCourse>();
            foreach (DataGridViewRow row in dgvApprenticeshipEnrollmentAvaiableCurriculumCourses.Rows)
            {
                if (row.Cells[ColAvailableSelector.Index].Value != null && (Boolean)row.Cells[ColAvailableSelector.Index].Value)
                {
                    CC.Add((CurriculumCourse)row.DataBoundItem);
                }
            }
            if (CC != null)
            {
                List<CurriculumCourseEnrollment> CCE = new List<CurriculumCourseEnrollment>();
                foreach (CurriculumCourse CCObj in CC)
                {
                    CCE.Add(new CurriculumCourseEnrollment
                    {
                        CurriculumCourseID = CCObj.CurriculumCourseID,
                        EnrollmentID = CurrentEnrollemnt.EnrollmentID,
                        CourseCost = CCObj.Cost
                    });
                };
                int iFieldsEffected = 0;
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.CurriculumCourseEnrollments.AddRange(CCE);
                    iFieldsEffected = Dbconnection.SaveChanges();
                    //if (iFieldsEffected > 0)
                    //{
                    //    Dbconnection.Enrollments.Attach(CurrentEnrollemnt);
                    //    Dbconnection.Entry(CurrentEnrollemnt).Reload();
                    //}
                };
            }
            populateLinkedCurriculumCourses();
            populateAvailableCurriculumCourses();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCourse_Click(object sender, EventArgs e)
        {
            List<CurriculumCourse> CC = new List<CurriculumCourse>();
            foreach (DataGridViewRow row in dgvApprenticeshipEnrollmentLinkedCurriculumCourses.Rows)
            {
                if (row.Cells[colLinkedCourseSelector.Index].Value != null && (Boolean)row.Cells[colLinkedCourseSelector.Index].Value)
                {
                    CC.Add(((CurriculumCourse)row.DataBoundItem));
                }
            }
            List<CurriculumCourseEnrollment> CCE = new List<CurriculumCourseEnrollment>();

            if (CC != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    foreach (CurriculumCourse CCObj in CC)
                    {
                        foreach (CurriculumCourseEnrollment CCEObj in CCObj.CurriculumCourseEnrollments)
                        {
                            Dbconnection.CurriculumCourseEnrollments.Attach(CCEObj);
                            CCE.Add(CCEObj);
                        }
                    }
                    Dbconnection.CurriculumCourseEnrollments.RemoveRange(CCE);
                    Dbconnection.SaveChanges();
                };
            }
            populateLinkedCurriculumCourses();
            populateAvailableCurriculumCourses();
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                var gridView = (DataGridView)sender;
                var chkValue = gridView.Rows[e.RowIndex].Cells[ColAvailableSelector.Index].Value;
                if (chkValue != null)
                {
                    if ((Boolean)chkValue)
                    {
                        gridView.Rows[e.RowIndex].Cells[ColAvailableSelector.Index].Value = false;
                    }
                    else
                    {
                        gridView.Rows[e.RowIndex].Cells[ColAvailableSelector.Index].Value = true;
                    }
                }
                else
                {
                    gridView.Rows[e.RowIndex].Cells[ColAvailableSelector.Index].Value = true;
                }


            }



        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colApprenticeshipEnrollmentAvailableCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }

        private void dgvApprenticeshipEnrollmentAvaiableCurriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvApprenticeshipEnrollmentLinkedCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);

                    row.Cells[colApprenticeshipEnrollmentLinkedCourse.Index].Value = CurriculumCourseObj.Course.CourseName.ToString();
                }
            }
        }

        private void dgvApprenticeshipEnrollmentLinkedCurriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void btnAvaiableSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApprenticeshipEnrollmentAvaiableCurriculumCourses.Rows)
            {
                //ColAvailableSelector
                row.Cells[ColAvailableSelector.Index].Value = true;
            }
        }
        private void unselectAllAvailableCourses()
        {
            foreach (DataGridViewRow row in dgvApprenticeshipEnrollmentAvaiableCurriculumCourses.Rows)
            {
                //ColAvailableSelector
                row.Cells[ColAvailableSelector.Index].Value = false;
            }
        }
        private void btnAvaiableUnSelectAll_Click(object sender, EventArgs e)
        {
            unselectAllAvailableCourses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvApprenticeshipEnrollmentLinkedCurriculumCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var gridView = (DataGridView)sender;
                var chkValue = gridView.Rows[e.RowIndex].Cells[colLinkedCourseSelector.Index].Value;
                if (chkValue != null)
                {
                    if ((Boolean)chkValue)
                    {
                        gridView.Rows[e.RowIndex].Cells[colLinkedCourseSelector.Index].Value = false;
                    }
                    else
                    {
                        gridView.Rows[e.RowIndex].Cells[colLinkedCourseSelector.Index].Value = true;
                    }
                }
                else
                {
                    gridView.Rows[e.RowIndex].Cells[colLinkedCourseSelector.Index].Value = true;
                }


            }
        }
    }
}
