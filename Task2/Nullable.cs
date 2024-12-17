using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Nullable
    {
        public void NullableDType()
        {
            // Nullable integer
            int? num = 20;

            // Check if the nullable variable has a value
            if (num.HasValue)
            {
                Console.WriteLine($"The value of num is {num.Value}");
            }
            else
            {
                Console.WriteLine("num is null");
            }

            // Assign a value to the nullable variable
            num = null;

            // Check again after assigning a value
            if (num.HasValue)
            {
                Console.WriteLine($"The value of num is {num.Value}");
            }
            else
            {
                Console.WriteLine("num is null");
            }

            // Using the null-coalescing operator (??)
            int defaultValue = num ?? 0; // If num is null, defaultValue will be assigned 0
            Console.WriteLine($"The value of defaultValue is {defaultValue}");

            // Nullable boolean
            bool? isAvailable = null;

            // Check nullable boolean
            Console.WriteLine($"isAvailable has a value: {isAvailable.HasValue}");
            Console.WriteLine($"isAvailable value: {isAvailable ?? false}"); // Default to false if null
        }
    }
}
