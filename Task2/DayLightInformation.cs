using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DayLightInformation
    {
        public void DLInformation()
        {
            // Get the local time zone
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            // Display time zone information
            Console.WriteLine("Time Zone: " + localTimeZone.DisplayName);
            Console.WriteLine("Standard Time: " + localTimeZone.StandardName);
            Console.WriteLine("Daylight Time: " + localTimeZone.DaylightName);

            // Check if daylight saving time is applicable
            bool isDaylightSaving = localTimeZone.IsDaylightSavingTime(DateTime.Now);
            Console.WriteLine("\nIs Daylight Saving Time currently active? " + (isDaylightSaving ? "Yes" : "No"));

            // If applicable, display DST adjustment rules
            if (localTimeZone.SupportsDaylightSavingTime)
            {
                TimeZoneInfo.AdjustmentRule[] adjustmentRules = localTimeZone.GetAdjustmentRules();
                foreach (var rule in adjustmentRules)
                {
                    Console.WriteLine($"\nDST Adjustment Rule:");
                    Console.WriteLine($"Start Date: {rule.DateStart:yyyy-MM-dd}");
                    Console.WriteLine($"End Date: {rule.DateEnd:yyyy-MM-dd}");
                    Console.WriteLine($"Daylight Delta: {rule.DaylightDelta}");
                }
            }
            else
            {
                Console.WriteLine("\nThis time zone does not support Daylight Saving Time.");
            }
        }
    }
}
