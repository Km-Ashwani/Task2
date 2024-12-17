using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NewModifier
    {
        
    }
    public class Birds
    {
        public void suckle()
        {
            Console.WriteLine("The birds can suckle");
        }
    }
    public class Sparrow:Birds
    {
        public new void suckle()
        {
            Console.WriteLine("the Sparrow can suckle");
        }
    }
}
