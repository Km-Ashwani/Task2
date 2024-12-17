using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle
    {
        public double length { get; set; }
        public double width { get; set; }

        public double CalculateArea()
        {
            return width * length;
        }
    }
    public class Plotcost:Rectangle
    {
        public double CostSquarePerUnit { get; set; }

        public double CalculateTotalcost()
        {
            return CalculateArea() * CostSquarePerUnit;
        }
    }

    public class Total
    {
        Plotcost plot = new Plotcost();
        public void PrintValue()
        {
            Console.WriteLine("Enter Width");
            plot.width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter length");
            plot.length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost square per units");
            plot.CostSquarePerUnit = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nArea of the plot: {plot.CalculateArea()} square units");
            Console.WriteLine($"Total cost of plot: {plot.CalculateTotalcost()} currency units");
        }
    }
}
