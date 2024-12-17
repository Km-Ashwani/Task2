using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class LeapYear
    {
        public void LeapY()
        {
            // Input year
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Check if the year is a leap year
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
