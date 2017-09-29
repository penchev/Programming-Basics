using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete duljinata na stranata na kvadrata: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Liceto na kvadrata e {a*a}");
        }
    }
}
