using Impendulo.Data.Models;
using MetroFramework.Forms;
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

namespace Impendulo.Scheduling.Development.AllCourses
{
    public partial class frmScheduleCurriculumCourses : MetroForm
    {
        /// <summary>
        /// Currently Selected CurriculumCourseEnrollment Object - with the Following collections loaded
        /// 1. -
        /// </summary>
        public CurriculumCourseEnrollment CurrentSelectedCurriculumCourseEnrollment { get; set; }

        /// <summary>
        /// Course Obj - contains the Linked Facilitators for the course and Venues to select from
        /// </summary>
        private CurriculumCourse CurrentlySelectedCurriculumCourseToSchedule { get; set; }
        public frmScheduleCurriculumCourses()
        {
            InitializeComponent();
        }

        private void frmScheduleCurriculumCourses_Load(object sender, EventArgs e)
        {
            prePopulateCurrentlySelectedCourse();
        }

        #region Pre-Populate Information
        private void prePopulateCurrentlySelectedCourse()
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurrentlySelectedCurriculumCourseToSchedule = CurrentSelectedCurriculumCourseEnrollment.CurriculumCourse;
                Dbconnection.CurriculumCourses.Attach(CurrentlySelectedCurriculumCourseToSchedule);
                //loads the days that can be scheduled.
                if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.CurriculumCourseDayCanBeScheduleds).IsLoaded)
                {
                    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.CurriculumCourseDayCanBeScheduleds).Load();
                }
                //load the course that associated with the Curriculum Course
                if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Reference<Course>(a => a.Course).IsLoaded)
                {
                    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Reference<Course>(a => a.Course).Load();
                }
               
                //if (!Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.Course.VenueAssociatedCourses).IsLoaded)
                //{
                //    Dbconnection.Entry(CurrentlySelectedCurriculumCourseToSchedule).Collection(a => a.Course.VenueAssociatedCourses).Load();
                //}


            };
        }
        #endregion
        #region REfresh Methods
        private void refersh()
        {

        }

        #endregion

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtLeadTimeForSchedulingSearch.Text = e.NewValue.ToString();

        }
    }
}
