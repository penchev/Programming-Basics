using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0, result = 0;
            int currentNumber = 0;
            for (int i = 0; i < n; i++)
            {

                currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                    sum1 = sum1 + currentNumber;
                else sum2 = sum2 + currentNumber;
            }

            result = sum1 - sum2;

            if(result==0)
                Console.WriteLine("Yes, sum = "+sum1);
            else Console.WriteLine("No, diff = " + Math.Abs(sum1-sum2));
        }
    }
}
