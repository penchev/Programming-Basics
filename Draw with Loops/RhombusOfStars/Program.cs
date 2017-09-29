using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int k = 0; k < n - row; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < row - 1; j++)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n-1; row++)
            {
                
                for (int k = 0; k < n - row; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                for (int i = 0; i < row; i++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
