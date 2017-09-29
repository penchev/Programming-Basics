using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {

            double L = double.Parse(Console.ReadLine());

            double W = double.Parse(Console.ReadLine());

            double A = double.Parse(Console.ReadLine());


            double sizeOfHall = 0;
            double sizeOfWardrobe = 0;
            double sizeOfPeika = 0;
            double freeSpace = 0;
            double numberOfDancers = 0;

            sizeOfHall = (L * 100) * (W * 100);
            sizeOfWardrobe = (A * 100) * (A * 100);
            sizeOfPeika = sizeOfHall / 10;
            freeSpace = sizeOfHall - sizeOfWardrobe - sizeOfPeika;
            numberOfDancers = (int)Math.Floor(freeSpace / 7040); ;
            Console.WriteLine(numberOfDancers);

        }
    }
}
