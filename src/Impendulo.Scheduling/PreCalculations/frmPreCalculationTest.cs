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
using Impendulo.Common.ScheduleAvailablityAlgorithm;
using static Impendulo.Common.ScheduleAvailablityAlgorithm.SchedulingDateSearchAlgorithms;

namespace Impendulo.Scheduling.Development.PreCalculations
{
    public partial class frmPreCalculationTest : Form
    {
        public frmPreCalculationTest()
        {
            InitializeComponent();
        }

        private void frmPreCalculationTest_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2017, 07, 01);
            //dt = dt.AddDays(-30);

            SchedulingDateSearchAlgorithms ScheduleAlgorthim = new SchedulingDateSearchAlgorithms(
                CourseIDBookingFor: 4,
                InitialDateToStartFrom: dt.Date,
                 AmountOfSearchTimeAhead: SearchTimeAhead.OneMonth,
                 CurriculumCourseID: 4117
                );
            dataGridView1.DataSource = ScheduleAlgorthim.CourseAvailableDateSets;
            txtOutput.Text += "Available dates:\n\n";
            foreach (FacilitatorAvailableDateSet aa in ScheduleAlgorthim.FacilitatorAvailableDateSets)
            {
                txtOutput.Text += aa.FacilitatorID.ToString() + " - StartDate: " + aa.StartDate + " - EndDate: " + aa.EndDate + "\n";
            }
            txtOutput.Text += "Booked Dates:\n\n";
            foreach (FacilitatorBookedDateSet aa in ScheduleAlgorthim.FacilitatorBookedDateSets)
            {
                txtOutput.Text += aa.FacilitatorID.ToString() + " - StartDate: " + aa.StartDate + " - EndDate: " + aa.EndDate + "\n";
            }
            foreach (FacilitatorAvailableDateSet aa in ScheduleAlgorthim.FacilitatorAvailableDateSets)
            {
                txtOutput.Text += aa.FacilitatorID.ToString() + " - StartDate: " + aa.StartDate + " - EndDate: " + aa.EndDate + "\n";
            }
            txtOutput.Text += "Booked Dates:\n\n";
            foreach (CourseAvailableDateSet aa in ScheduleAlgorthim.CourseAvailableDateSets)
            {
                txtOutput.Text += aa.FacilitatorID.ToString() + "CurriculumCourseID: " + aa.CurriculumCourseID + " - StartDate: " + aa.StartDate + " - EndDate: " + aa.EndDate + "\n";
            }
        }
        //Orientateion is ID = 4
        private void GetAllFacilitatorForSelectedCourse()
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<Facilitator> f = (from a in Dbconnection.Facilitators
                                       from b in a.FacilitatorAssociatedCourses
                                       where b.CourseID == 4
                                       select a).ToList<Facilitator>();


                List<object> s = new List<object>();

                foreach (Facilitator AvaiableFacilitaor in f)
                {

                    //var aa = (from a in Dbconnection.Schedules
                    //          where a.ScheduleStartDate >= dt.Date &&
                    //          a.FacilitatorID == AvaiableFacilitaor.FacilitatorID
                    //          select new
                    //          {
                    //              FacilitatorID = a.FacilitatorID,
                    //              ScheduleStartDate = a.ScheduleStartDate,
                    //              ScheduleCompletionDate = a.ScheduleCompletionDate

                    //          }).OrderBy(a => a.ScheduleStartDate).Distinct().ToList();
                    //foreach (var FaciliatorBookedDates in aa)
                    //{
                    //    FacilitatorBookedDateSet FBDS = new FacilitatorBookedDateSet(
                    //        FacilitatorID: FaciliatorBookedDates.FacilitatorID,
                    //         StartDate: FaciliatorBookedDates.ScheduleStartDate,
                    //         EndDate: FaciliatorBookedDates.ScheduleCompletionDate);
                    //    ScheduleAlgorthim.FacilitatorBookedDateSets.Add(FBDS);
                    //}


                }

                string xrsd = "";
                //var t = (from a in Dbconnection.Schedules
                //         where a.FacilitatorID == AvaiableFacilitaor.FacilitatorID
                //         group a by a.ScheduleStartDate into g

                //         select new
                //         {

                //             CurrentFacilitatorID = AvaiableFacilitaor.FacilitatorID,
                //             CurrentFacilitatorName = AvaiableFacilitaor.Individual.FullName,
                //             StartDate = g.Key,
                //             GroupedScheduleEnrollments = g
                //         }).ToList();
                //if (t.Count > 0)
                //    s.Add(t);
                //List<Schedule> ss = (from a in Dbconnection.Schedules
                //                     where a.FacilitatorID == AvaiableFacilitaor.FacilitatorID
                //                     //orderby a.ScheduleStartDate
                //                     select a
                //                     ).ToList();
                //string xrsd = "";


                /*REquired
                 var xx = (from a in Dbconnection.Schedules
                           where a.ScheduleStartDate > dt
                           group a by a.ScheduleStartDate into cc
                           select cc).ToList();

                 var yy = (from a in Dbconnection.Schedules
                           where a.ScheduleStartDate > dt
                           select new
                           {
                               FacilitatorID = a.FacilitatorID,
                               ScheduleStartDate = a.ScheduleStartDate,
                               ScheduleCompletionDate = a.ScheduleCompletionDate

                           }).OrderBy(a => a.ScheduleStartDate).Distinct().ToList();
                 */

                //foreach (Facilitator AvaiableFacilitaor in f)
                //{
                //    var t = (from a in Dbconnection.Schedules
                //                 //where a.FacilitatorID == AvaiableFacilitaor.FacilitatorID
                //             group a by a.ScheduleStartDate into g

                //             select new { g.Key, GroupedScheduleEnrollments = g }).ToList();
                //}
            };
        }
    }
}
