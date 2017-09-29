using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExam16
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            h = h * 100;
            w = w * 100;

            double workWidht = w-100;
            double workHeight = h;
            int counter = 0;
            int counter2 = 0;
            while (workWidht >= 70)
            {
                workWidht = workWidht - 70;
                
                counter = counter + 1;
            }
            while (workHeight >= 120)
            {
                workHeight = workHeight - 120;
                counter2 = counter2 + 1;
            }
            int result = counter * counter2 - 3;
            Console.WriteLine("{0}",result);
        }
    }
}
