using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i <=n; i++)
            {
                for (int k = 0; k < n-i; k++)
                {
                    Console.Write(" ");
                }
                
                
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}
