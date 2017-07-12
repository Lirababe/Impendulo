using Impendulo.Common;
using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Scheduling.Development.PreCalculations
{
    public class SchedulingDateSearchAlgorithms
    {
        public enum EnumEnrollmentTypes : int
        {
            Novice = 1, ReCertification = 2
        }
        public enum SearchTimeAhead : int
        {
            OneMonth = 1,
            ThreeMonths = 3,
            SixMonth = 6,
            NineMonths = 9,
            TwelveMonths = 12,
            TwentyFourMonths = 24

        }
        public SchedulingDateSearchAlgorithms(
            int CourseIDBookingFor,
            DateTime InitialDateToStartFrom,
            SearchTimeAhead AmountOfSearchTimeAhead,
             int CurriculumCourseID)
        {
            this.CourseIDBookingFor = CourseIDBookingFor;
            this.InitalDate = InitialDateToStartFrom;
            this.AmountOfSearchTimeAhead = AmountOfSearchTimeAhead;
            this.CurriculumCourseID = CurriculumCourseID;

            FacilitatorAvailableDateSets = new List<FacilitatorAvailableDateSet>();
            FacilitatorBookedDateSets = new List<FacilitatorBookedDateSet>();
            CourseAvailableDateSets = new List<CourseAvailableDateSet>();

            SetBookedDatesForFacilitators();
            SetAvailableDatesForFacilitators();
            SetPossibleCurriculumCourseDates();
        }

        public List<FacilitatorAvailableDateSet> FacilitatorAvailableDateSets { get; set; }
        public List<FacilitatorBookedDateSet> FacilitatorBookedDateSets { get; set; }
        public List<CourseAvailableDateSet> CourseAvailableDateSets { get; set; }

        private SearchTimeAhead AmountOfSearchTimeAhead { get; set; }
        private int CourseIDBookingFor { get; set; }
        private DateTime InitalDate { get; set; }
        private DateTime CurrentSearchDate { get; set; }

        private int CurriculumCourseID { get; set; }


        public FacilitatorBookedDateSet IsDateInAnySet(List<FacilitatorBookedDateSet> SetsOfBookedDatesPreFacilitator, DateTime DateIndex)
        {
            FacilitatorBookedDateSet Rtn = null;

            foreach (FacilitatorBookedDateSet FBDS in SetsOfBookedDatesPreFacilitator)
            {
                if ((FBDS.StartDate.Date <= DateIndex.Date) && (FBDS.EndDate.Date >= DateIndex))
                {
                    return FBDS;
                }
            }

            return Rtn;
        }

        public class CourseAvailableDateSet
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int FacilitatorID { get; set; }
            public int CurriculumCourseID { get; set; }
            public CourseAvailableDateSet(int FacilitatorID, int CurriculumCourseID, DateTime StartDate, DateTime EndDate)
            {
                this.FacilitatorID = FacilitatorID;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
                this.CurriculumCourseID = CurriculumCourseID;
            }

            public int GetAmountOfDaysInSet()
            {
                int Rtn;
                Rtn = EndDate.Date.Subtract(StartDate).Days;
                return Rtn;
            }

        }
        public class FacilitatorAvailableDateSet
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int FacilitatorID { get; set; }
            public FacilitatorAvailableDateSet(int FacilitatorID, DateTime StartDate, DateTime EndDate)
            {
                this.FacilitatorID = FacilitatorID;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
            }

            public int GetAmountOfDaysInSet()
            {
                int Rtn;
                Rtn = EndDate.Date.Subtract(StartDate).Days;
                return Rtn;
            }

        }
        public class FacilitatorBookedDateSet
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int FacilitatorID { get; set; }
            public FacilitatorBookedDateSet(int FacilitatorID, DateTime StartDate, DateTime EndDate)
            {
                this.FacilitatorID = FacilitatorID;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
            }

            public int GetAmountOfDaysInSet()
            {
                int Rtn;
                Rtn = EndDate.Date.Subtract(StartDate).Days;
                return Rtn;
            }

        }



        public List<Facilitator> GetAllFacilitatorsForSelectedCourse()
        {
            List<Facilitator> Rtn = new List<Facilitator>();
            using (var Dbconnection = new MCDEntities())
            {

                List<Facilitator> f = (from a in Dbconnection.Facilitators
                                       from b in a.FacilitatorAssociatedCourses
                                       where b.CourseID == CourseIDBookingFor
                                       select a).ToList<Facilitator>();
                if (f != null)
                {
                    foreach (Facilitator FacilitatorObj in f)
                    {
                        Rtn.Add(FacilitatorObj);
                    }
                }
            };
            return Rtn;
        }

        public void SetAvailableDatesForFacilitators()
        {
            DateTime SearchEndDate;
            SearchEndDate = this.InitalDate.Date.AddMonths((int)this.AmountOfSearchTimeAhead);

            //For EAch Facilitator
            foreach (int FacilitatorID in (from a in FacilitatorBookedDateSets
                                           select a.FacilitatorID).Distinct<int>().ToList<int>())
            {
                //Steps through their Set of Booked Dates to Determine Available DateSets
                List<FacilitatorBookedDateSet> FBDS = (from a in FacilitatorBookedDateSets
                                                       where a.FacilitatorID == FacilitatorID
                                                       orderby a.StartDate
                                                       select a).ToList<FacilitatorBookedDateSet>();
                // {
                DateTime INITIAL_DATE = this.InitalDate.Date;
                DateTime CURRENT_SEARCH_INDEX_DATE = this.InitalDate.Date;

                //Initial Check To Catch the first Day - IF It Booked
                FacilitatorBookedDateSet FBDS_RETURNED_AS_FOUND = IsDateInAnySet(SetsOfBookedDatesPreFacilitator: FBDS, DateIndex: CURRENT_SEARCH_INDEX_DATE);
                //If Null No DataSet Found.
                while (FBDS_RETURNED_AS_FOUND != null)
                {
                    //Date Index Is Currently In With In A Booked Set.
                    FacilitatorAvailableDateSets.Add(new FacilitatorAvailableDateSet(FacilitatorID, INITIAL_DATE.Date, FBDS_RETURNED_AS_FOUND.StartDate.Date));
                    INITIAL_DATE = FBDS_RETURNED_AS_FOUND.EndDate.Date.AddDays(1);
                    CURRENT_SEARCH_INDEX_DATE = FBDS_RETURNED_AS_FOUND.EndDate.Date.AddDays(1);
                }


                //Checks Each Day Ahead to See If It Falls Into A Booked Time Period.
                while (CURRENT_SEARCH_INDEX_DATE < SearchEndDate)
                {
                    //Check if the Current Start Date Is In Any Of the Booked Date Sets 
                    FBDS_RETURNED_AS_FOUND = IsDateInAnySet(SetsOfBookedDatesPreFacilitator: FBDS, DateIndex: CURRENT_SEARCH_INDEX_DATE.Date.AddDays(1));
                    //If Null No DataSet Found.
                    if (FBDS_RETURNED_AS_FOUND == null)
                    {
                        //Current DateIndex Not In Any Booked Date Sets
                        CURRENT_SEARCH_INDEX_DATE = CURRENT_SEARCH_INDEX_DATE.AddDays(1);


                    }
                    else
                    {
                        //Date Index Is Currently In With In A Booked Set.
                        FacilitatorAvailableDateSets.Add(new FacilitatorAvailableDateSet(FacilitatorID, INITIAL_DATE.Date, FBDS_RETURNED_AS_FOUND.StartDate.AddDays(-1)));
                        INITIAL_DATE = FBDS_RETURNED_AS_FOUND.EndDate.Date.AddDays(1);
                        CURRENT_SEARCH_INDEX_DATE = FBDS_RETURNED_AS_FOUND.EndDate.Date;
                        // CURRENT_SEARCH_INDEX_DATE = CURRENT_SEARCH_INDEX_DATE.AddDays(1);
                    }

                }
                FBDS_RETURNED_AS_FOUND = IsDateInAnySet(SetsOfBookedDatesPreFacilitator: FBDS, DateIndex: CURRENT_SEARCH_INDEX_DATE);
                //Capture the Last Possiable Dte Set Avaiable
                if (FBDS_RETURNED_AS_FOUND == null)
                {
                    //Date Index Is Currently In With In A Booked Set.
                    FacilitatorAvailableDateSets.Add(new FacilitatorAvailableDateSet(FacilitatorID, INITIAL_DATE.Date, CURRENT_SEARCH_INDEX_DATE.Date));
                }
            }

        }
        public void SetBookedDatesForFacilitators()
        {
            using (var Dbconnection = new MCDEntities())
            {
                foreach (Facilitator AvailableFacilitaor in GetAllFacilitatorsForSelectedCourse())
                {


                    var SetOfFacilitatorSchedules = (from a in Dbconnection.Schedules
                                                     where a.ScheduleStartDate >= InitalDate.Date &&
                                                     a.FacilitatorID == AvailableFacilitaor.FacilitatorID
                                                     select new
                                                     {
                                                         FacilitatorID = a.FacilitatorID,
                                                         ScheduleStartDate = a.ScheduleStartDate,
                                                         ScheduleCompletionDate = a.ScheduleCompletionDate

                                                     }).OrderBy(a => a.ScheduleStartDate).Distinct().ToList();
                    foreach (var FaciliatorBookedDates in SetOfFacilitatorSchedules)
                    {
                        FacilitatorBookedDateSet FBDS = new FacilitatorBookedDateSet(
                            FacilitatorID: FaciliatorBookedDates.FacilitatorID,
                             StartDate: FaciliatorBookedDates.ScheduleStartDate,
                             EndDate: FaciliatorBookedDates.ScheduleCompletionDate);
                        //add To List
                        FacilitatorBookedDateSets.Add(FBDS);
                    }
                }
            };
        }

        public void SetPossibleCurriculumCourseDates()
        {
            List<CurriculumCourseDayCanBeScheduled> CurriculumCourseDayCanBeScheduledDays = new List<CurriculumCourseDayCanBeScheduled>();
            int iDuration = 0;
            using (var Dbconnection = new MCDEntities())
            {
                iDuration = (from a in Dbconnection.CurriculumCourses
                             where a.CurriculumCourseID == this.CurriculumCourseID
                             select a.Duration).First<int>();
                CurriculumCourseDayCanBeScheduledDays = (from a in Dbconnection.CurriculumCourseDayCanBeScheduleds
                                                         where a.CurriculumCourseID == this.CurriculumCourseID
                                                         select a).ToList<CurriculumCourseDayCanBeScheduled>();

            };

            List<EnumDayOfWeeks> EnumDayOfWeeksList = new List<EnumDayOfWeeks>();
            foreach (CurriculumCourseDayCanBeScheduled CurriculumCourseDayCanBeScheduledDayObj in CurriculumCourseDayCanBeScheduledDays)
            {
                EnumDayOfWeeksList.Add((EnumDayOfWeeks)CurriculumCourseDayCanBeScheduledDayObj.DayOfWeekID);
            }

            foreach (FacilitatorAvailableDateSet FADS in FacilitatorAvailableDateSets)
            {
                DateTime INITIAL_DATE = FADS.StartDate;

                //Get First Dat That Scheduling Can Start
                DateTime FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET = FADS.StartDate;
                while (FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET.Date < FADS.EndDate.Date)
                {
                    Boolean IsFirstDayFound = false;
                    while (!IsFirstDayFound)
                    {
                        if (IsFirstDateCanBeScheduled(FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET, CurriculumCourseDayCanBeScheduledDays))
                        {
                            IsFirstDayFound = true;
                        }
                        else
                        {
                            FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET = FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET.AddDays(1);
                        }
                    }

                    DateTime EndDateForCurrentPossibleSchedule = CustomDateTime.getCustomDateTime(FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET, iDuration, EnumDayOfWeeksList);
                    if (EndDateForCurrentPossibleSchedule.Date <= FADS.EndDate.Date)
                    {
                        //Add Schedule Option To List
                        CourseAvailableDateSets.Add(new CourseAvailableDateSet(
                            FacilitatorID: FADS.FacilitatorID,
                             CurriculumCourseID: this.CurriculumCourseID,
                              StartDate: FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET.Date,
                               EndDate: EndDateForCurrentPossibleSchedule.Date));
                        FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET = EndDateForCurrentPossibleSchedule.Date.AddDays(1);

                    }
                    else
                    {
                        FIRST_DAY_CAN_BE_SCHEDULED_FROM_SET = FADS.EndDate.Date;
                    }

                }

            }
        }

        public Boolean IsFirstDateCanBeScheduled(DateTime CurrentDay, List<CurriculumCourseDayCanBeScheduled> CurriculumCourseDayCanBeScheduledList)
        {
            Boolean Rtn = false;


            EnumDayOfWeeks DayOfTheWeek = CustomDateTime.CustomDayOfTheWeek(CurrentDay.DayOfWeek);
            int AmountOfDayFound = (from a in CurriculumCourseDayCanBeScheduledList
                                    where a.DayOfWeekID == (int)DayOfTheWeek
                                    select a).ToList<CurriculumCourseDayCanBeScheduled>().Count();
            if (AmountOfDayFound > 0)
            {
                Rtn = true;
            }

            return Rtn;

        }
    }
}
