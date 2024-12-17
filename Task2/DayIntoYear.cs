using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DayIntoYear
    {
        public void dayYear()
        {
            // Input total number of days
            Console.Write("Enter the total number of days: ");
            int totalDays = int.Parse(Console.ReadLine());

            // Conversion logic
            int years = totalDays / 365;               // 1 year = 365 days
            int remainingDaysAfterYears = totalDays % 365;
            int months = remainingDaysAfterYears / 30; // Approx. 1 month = 30 days
            int days = remainingDaysAfterYears % 30;

            // Display the result
            Console.WriteLine($"{totalDays} days is equivalent to:");
            Console.WriteLine($"{years} years, {months} months, and {days} days.");
        }
    }
}
