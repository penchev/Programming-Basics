﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());

            if (ocenka >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }else
                Console.WriteLine("Not excellent.");
        }
    }
}
