using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inch = ");
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("Centimeters = {0}",cm);
        }
    }
}
