using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Universaltime
    {
        public void UTime()
        {
            // Get the current UTC time
            DateTime utcTime = DateTime.UtcNow;

            // Display the UTC time
            Console.WriteLine("The current Universal Time (UTC) is: " + utcTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
