using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacityOfStadium = int.Parse(Console.ReadLine());
            double numberOfUltras = double.Parse(Console.ReadLine());
            double sectorA = 0, sectorB = 0, sectorV = 0, sectorG = 0;
            for (int i = 0; i < numberOfUltras; i++)
            {
                char sector = char.Parse(Console.ReadLine().ToLower());
                if (sector == 'a')
                    sectorA++;
                else if (sector == 'b')
                    sectorB++;
                else if (sector == 'v')
                    sectorV++;
                else if (sector == 'g')
                    sectorG++;


            }

            sectorA = sectorA / numberOfUltras * 100;
            sectorB = sectorB / numberOfUltras * 100;
            sectorV = sectorV / numberOfUltras * 100;
            sectorG = sectorG / numberOfUltras * 100;

            numberOfUltras = numberOfUltras / capacityOfStadium * 100;

            Console.WriteLine("{0:f2}%",sectorA);
            Console.WriteLine("{0:f2}%", sectorB);
            Console.WriteLine("{0:f2}%", sectorV);
            Console.WriteLine("{0:f2}%", sectorG);
            Console.WriteLine("{0:f2}%", numberOfUltras);
        }
    }
}
