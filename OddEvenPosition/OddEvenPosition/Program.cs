using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double smallestOdd = double.MaxValue, smallestEven = double.MaxValue;
            double largestOdd = double.MinValue, largestEven = double.MinValue;
            double sumEven = 0, sumOdd = 0;
            double currentNumber = 0;
            int counter1 = 0, counter2 = 0;

            for (int i = 1; i <= n; i++)
            {

                currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    counter2++;
                    if (currentNumber > largestEven)
                        largestEven = currentNumber;
                   if (currentNumber < smallestEven)
                        smallestEven = currentNumber;
                    sumEven = sumEven + currentNumber;
                }
                else
                {
                    counter1++;
                    if (currentNumber > largestOdd)
                        largestOdd = currentNumber;
                    if (currentNumber < smallestOdd)
                        smallestOdd = currentNumber;
                    sumOdd = sumOdd + currentNumber;
                }
            }
            Console.WriteLine("OddSum=" + sumOdd);
            if (counter1 != 0)
            {
                Console.WriteLine("OddMin=" + smallestOdd);
                Console.WriteLine("OddMax=" + largestOdd);
            }
            else
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }
            Console.WriteLine("EvenSum=" + sumEven);
            if (counter2 != 0)
            {
                Console.WriteLine("EvenMin=" + smallestEven);
                Console.WriteLine("EvenMax=" + largestEven);
            }
            else
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
