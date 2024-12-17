using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class LocalTime
    {
        public void LCTime()
        {
            // Get the current local time
            DateTime localTime = DateTime.Now;

            // Display the local time
            Console.WriteLine("Local Time: " + localTime.ToString("F"));

            // Wait for user input to close the program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
