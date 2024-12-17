using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Animal2
    {
        public void Eat()
        {
            Console.WriteLine("The animal can Eat");
        }
    }
    public class Mammal:Animal2
    {
        public void Run()
        {
            Console.WriteLine("The Mammal can Run");
        }
    }
    public class Dog2:Mammal
    {
        public void Bark()
        {
            Console.WriteLine("The dog can bark");
        }
    }
}
