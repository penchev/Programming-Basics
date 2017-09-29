using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_area_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r= ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Perimeter = {0}",perimeter);
        }
    }
}
