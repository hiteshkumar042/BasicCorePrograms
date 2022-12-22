using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void LeapYearFn()
        {
            Console.Write("Enter to Year (YYYY) to Check if it is Leap Year or Not: ");
            //taking user input
            int year = Convert.ToInt32(Console.ReadLine());
            //checking the condition to find leap year
            if ((year%400==0) || (year%4==0 && year%100!=0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }
    }
}
