using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            int currentNumber = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {

                currentNumber = int.Parse(Console.ReadLine());
                sum1 = sum1 + currentNumber;
            }

            for (int i = 0; i < n; i++)
            {

                currentNumber = int.Parse(Console.ReadLine());
                sum2 = sum2 + currentNumber;
            }
            result = sum1 - sum2;

            if(result==0)
                Console.WriteLine("Yes, sum = " + sum1);
            else Console.WriteLine("No, diff = "+Math.Abs(sum1-sum2));
        }
    }
}
