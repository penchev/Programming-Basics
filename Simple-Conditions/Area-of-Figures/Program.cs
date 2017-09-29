using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double a = 0;
            double b = 0;

            if (type == "square")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", a * a);
            }
            else if (type == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", a * b);
            }
            else if (type == "circle")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", Math.PI*a*a);
            }
            else if (type == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", a*b/2);
            }
        }
    }
}
