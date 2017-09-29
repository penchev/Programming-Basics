using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber;
            }
            Console.WriteLine(sum);


        }
    }
}
