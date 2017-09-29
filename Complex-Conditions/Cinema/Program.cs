using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(type=="premiere")
                Console.WriteLine("{0:0.00}",r*c*12);
            else if(type=="normal")
                Console.WriteLine("{0:0.00}", r * c * 7.5);
            else if(type=="discount")
                Console.WriteLine("{0:0.00}", r * c * 5);
            else Console.WriteLine("error");
        }
    }
}
