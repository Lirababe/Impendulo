using Impendulo.Common.Enum;
using Impendulo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Common
{
    public static class CustomDateTime
    {
        public static DateTime getCustomDateTime(DateTime CurrentDate, int AmountDaysToAdd, List<EnumDayOfWeeks> DaysCanSchedule)
        {
            while (!(AmountDaysToAdd == 0))
            {
                //if the next day can be scheduled
                if (IsDayThatCanBeScheduled(CustomDayOfTheWeek(CurrentDate.AddDays(1).DayOfWeek), DaysCanSchedule))
                {
                    if (AmountDaysToAdd < 0)
                    {
                        CurrentDate = CurrentDate.AddDays(-1);
                        AmountDaysToAdd++;
                    }
                    else
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                        AmountDaysToAdd--;
                    }
                }
                else
                {
                    if (AmountDaysToAdd < 0)
                    {
                        CurrentDate = CurrentDate.AddDays(-1);
                    }
                    else
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                    }
                }
            }

            return CurrentDate;
        }
        private static Boolean IsDayThatCanBeScheduled(EnumDayOfWeeks CurrentDay, List<EnumDayOfWeeks> DaysCanSchedule)
        {
            Boolean Rtn = false;

            foreach (EnumDayOfWeeks d in DaysCanSchedule)
            {
                if (CurrentDay == d)
                {
                    Rtn = true;
                }
            }

            return Rtn;
        }
        public static EnumDayOfWeeks CustomDayOfTheWeek(DayOfWeek Day)
        {
            EnumDayOfWeeks CustomDay = EnumDayOfWeeks.Monday;
            switch (Day)
            {
                case System.DayOfWeek.Monday:
                    CustomDay = EnumDayOfWeeks.Monday;
                    break;
                case System.DayOfWeek.Tuesday:
                    CustomDay = EnumDayOfWeeks.Tuesday;
                    break;
                case System.DayOfWeek.Wednesday:
                    CustomDay = EnumDayOfWeeks.Wednesday;
                    break;
                case System.DayOfWeek.Thursday:
                    CustomDay = EnumDayOfWeeks.Thursday;
                    break;
                case System.DayOfWeek.Friday:
                    CustomDay = EnumDayOfWeeks.Friday;
                    break;
                case System.DayOfWeek.Saturday:
                    CustomDay = EnumDayOfWeeks.Saturday;
                    break;
                case System.DayOfWeek.Sunday:
                    CustomDay = EnumDayOfWeeks.Sunday;
                    break;
            }

            return CustomDay;
        }
        public static DateTime getCustomDateTime(DateTime CurrentDate, int AmountDaysToAdd)
        {
            int iCount = 0;


            while (!(AmountDaysToAdd == 0))
            {
                if ((CurrentDate.DayOfWeek != DayOfWeek.Saturday && CurrentDate.DayOfWeek != DayOfWeek.Sunday))
                {

                    if (AmountDaysToAdd < 0)
                    {
                        CurrentDate = CurrentDate.AddDays(-1);
                        AmountDaysToAdd++;
                    }
                    else
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                        iCount--;
                    }
                }
                else
                {
                    if (AmountDaysToAdd < 0)
                    {
                        CurrentDate = CurrentDate.AddDays(-1);
                    }
                    else
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                    }
                }
            }
            return CurrentDate;
        }
    }
}
