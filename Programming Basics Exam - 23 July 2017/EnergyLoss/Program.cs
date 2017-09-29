using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int energy = 100 * n * a;
            int energyLoss = 0;
            int sumEnergy = 0;
            double neizhabena = 0;

            for (int i = 1; i <= n; i++)
            {

                int hours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && hours % 2 == 0)
                    energyLoss = 68 * a;
                else if (i % 2 != 0 && hours % 2 == 0)
                    energyLoss = 49 * a;
                else if (i % 2 == 0 && hours % 2 != 0)
                    energyLoss = 65 * a;
                else if (i % 2 != 0 && hours % 2 != 0)
                    energyLoss = 30 * a;
                sumEnergy = sumEnergy + energyLoss;
            }
            neizhabena = energy - sumEnergy;
            neizhabena = neizhabena / a / n;

            if (neizhabena<=50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", neizhabena);
            }else
                Console.WriteLine("They feel good! Energy left: {0:f2}", neizhabena);

        }
    }
}
