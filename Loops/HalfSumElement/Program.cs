using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int currentNumber = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggest)
                    biggest = currentNumber;
                sum = sum + currentNumber;
            }

            sum = sum - biggest;
            if (sum == biggest)
                Console.WriteLine("Yes, sum = " + biggest);
            else Console.WriteLine("No, diff = " + Math.Abs(sum - biggest));
        }
        }
    }


