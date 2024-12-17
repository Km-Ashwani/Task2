using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class VariousTime
    {
        public void VTime()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Display the date in various formats
            Console.WriteLine("Default format: " + currentDate);
            Console.WriteLine("Short date: " + currentDate.ToShortDateString());
            Console.WriteLine("Long date: " + currentDate.ToLongDateString());
            Console.WriteLine("Full date and time: " + currentDate.ToString("F"));
            Console.WriteLine("Month and year: " + currentDate.ToString("MMMM yyyy"));
            Console.WriteLine("Day, Month and Year: " + currentDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("ISO format: " + currentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Custom format: " + currentDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        }
    }
}
