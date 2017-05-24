using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impendulo.Common.CustomerDateTime
{
    public static class CustomerDateTime
    {
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
