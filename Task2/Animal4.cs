using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Animal4
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal make sounds");
        }
    }
    public class Monkey:Animal4
    {
        public override void sound()
        {
            Console.WriteLine("The Monkey make various sounds");
        }
    }
    public class Tiger:Animal4
    {
        public override void sound()
        {
            Console.WriteLine("The Tiger can roar");
        }
    }
}
