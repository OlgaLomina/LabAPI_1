using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAPI_1
{
    class Program
    {
        private static DateTime date_v;

        static void Main(string[] args)
        {
            Console.Write("Input date: ");
            DateTime date_input = Convert.ToDateTime(Console.ReadLine());
            int i_year = date_input.Year;
            if (MyDate.IsLeapYear(i_year))
            {
                Console.WriteLine("Year {0} is leap", i_year);
            }
            else
            {
                Console.WriteLine("Year {0} is not leap", i_year);
            }
            
            if (MyDate.IsBefore(date_input))
            {
                Console.Write("Date is before today");
            }
            else
            {
                Console.Write("Date is not before today");
            }
            Console.WriteLine();
            if (MyDate.IsAfter(date_input))
            {
                Console.Write("Date is after today");
            }
            else
            {
                Console.Write("Date is not after today");
            }
            Console.WriteLine();
            DateTime dToday = DateTime.Today;
            i_year = dToday.Year;
            int j = MyDate.DayInYear();
            Console.WriteLine("Date is the {0}th day of {1} year.", j, i_year);

        }
    }
}
