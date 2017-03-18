using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAPI_1
{
    public static class MyDate
    {
        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// Checks whether the given year is a leap year
        /// </summary>
        /// <param name="year">Year to be verified</param>
        /// <returns>true if it is a leap year, otherwise false</returns>
        public static bool IsLeapYear(int year)
        {
            bool b = true;
            b = (year % 4 == 0) && !(year % 100 == 0 && year % 400 != 0);
            /// return (year % 4 == 0) && !(year % 100 == 0 && year % 400 != 0);
            return b;
        }

        /// <summary>
        /// Determine if this date d is before today's date
        /// </summary>
        /// <param name="d"></param>
        /// <returns>true if it is, otherwise false</returns>
        public static bool IsBefore(DateTime d)
        {
            bool b = true;
            DateTime d_today = DateTime.Today;
            TimeSpan nDay = d_today - d;
            int v1 = nDay.Days;
            //string nCountDay = String.Format("{0:d}", nDay.Days);
            //int v1 = Convert.ToInt32(nCountDay);
            if (v1 > 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        /// <summary>
        /// Determine if this date d is after today's date
        /// </summary>
        /// <param name="d"></param>
        /// <returns>true if it is, otherwise false</returns>
        public static bool IsAfter(DateTime d)
        {
            bool b = true;
            DateTime d_today = DateTime.Today;
            TimeSpan nDay = d_today - d;
            int v1 = nDay.Days;
            if (v1 < 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        /// <summary>
        /// Returns the number of today in the year
        /// </summary>
        /// <returns>returns a number 1...366, inclusive, such that this Date is the nth day of its year.</returns>
        public static int DayInYear()
        {
            DateTime dToday = DateTime.Today;
            int dYear = dToday.Year;
            string date = "01/01/" + Convert.ToString(dYear);
            DateTime d = Convert.ToDateTime(date);
            TimeSpan nDay = dToday - d;

            int k = nDay.Days;
            return k;
        }

        #endregion
    }
}
