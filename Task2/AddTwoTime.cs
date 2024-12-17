using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class AddTwoTime
    {
        public void AddTime()
        {
            // Get the current date
            DateTime date1 = DateTime.Now;

            // Define the second date as a time interval using TimeSpan
            TimeSpan interval = new TimeSpan(5, 4, 30, 0); // 5 days, 4 hours, 30 minutes

            // Add the time interval to the first date
            DateTime resultDate = date1.Add(interval);

            // Display the results
            Console.WriteLine("Initial Date: " + date1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("Interval to Add: " + interval);
            Console.WriteLine("Resulting Date: " + resultDate.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
