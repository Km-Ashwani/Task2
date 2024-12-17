using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape");
        }
    }
    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    public class Rectangle2:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawnig a rectangle2");
        }
    }
}
