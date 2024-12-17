using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Animal3
    {
        public void Eat()
        {
            Console.WriteLine("The Animal can eat");
        }
    }
    public class Cat:Animal3
    {
        public void Meow()
        {
            Console.WriteLine("The cat says meow meow");
        }
    }
    public class Lion:Animal3
    {
        public void Roar()
        {
            Console.WriteLine("The Lion can Roar");
        }
    }
}
