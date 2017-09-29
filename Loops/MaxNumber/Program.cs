using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int biggest = int.MinValue;
            int currentNumber = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggest)
                    biggest = currentNumber;
            }
            Console.WriteLine(biggest);
        }
    }
}
