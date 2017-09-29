﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);

            double area = x * y;
            double perimeter = 2 * (x + y);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}