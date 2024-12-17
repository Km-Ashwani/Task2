using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CompareDate
    {
        public void CPDate()
        {
            // Input two dates
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date (yyyy-MM-dd): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            // Compare the dates
            if (date1 == date2)
            {
                Console.WriteLine("Both dates are equal.");
            }
            else if (date1 > date2)
            {
                Console.WriteLine("The first date is later than the second date.");
            }
            else
            {
                Console.WriteLine("The first date is earlier than the second date.");
            }

            // Display the dates for clarity
            Console.WriteLine("\nFirst Date: " + date1.ToString("yyyy-MM-dd"));
            Console.WriteLine("Second Date: " + date2.ToString("yyyy-MM-dd"));
        }
    }
}
