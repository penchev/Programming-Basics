using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_in_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double firstTube = 0, secondTube = 0;
            double sum = 0;
            double difference = 0;

            firstTube = h * p1;
            secondTube = h * p2;
            sum = firstTube + secondTube;

            if (sum < V)
            {
                firstTube = (int)((firstTube*100) / sum);
                secondTube = (int)((secondTube*100) / sum);
                sum = sum / 10;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                    ,sum,firstTube,secondTube);
            }
            else
            {
                difference = sum - V;
                Console.WriteLine("For {0} hours the pool overflows with {1:0.0} liters.",h,difference);
            }
        }
    }
}
