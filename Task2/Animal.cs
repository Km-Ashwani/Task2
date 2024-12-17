using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task2
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal can eat");
        }
    }
    public class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("The dog can bark");
        }
    }
}
