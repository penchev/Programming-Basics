using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool even = number%2 == 0;
            if (even==true)
            Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
