using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            string inputDimension = Console.ReadLine();
            string outputDimension = Console.ReadLine();
            double result = 0;

            if (inputDimension == "m")
            {
                if (outputDimension == "m")
                    result = chislo;
                if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
            }
            else if (inputDimension == "mm")
            {
                if (outputDimension == "mm")
                    result = chislo;
                chislo = chislo / 1000;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;

            }
            else if (inputDimension == "mi")
            {
                if (outputDimension == "mi")
                    result = chislo;
                chislo = chislo / 0.000621371192;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
            }
            else if (inputDimension == "in")
            {
                if (outputDimension == "in")
                    result = chislo;
                chislo = chislo / 39.3700787;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
            }
            else if (inputDimension == "km")
            {
                if (outputDimension == "km")
                    result = chislo;
                chislo = chislo / 0.001;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
            }
            else if (inputDimension == "ft")
            {
                if (outputDimension == "ft")
                    result = chislo;
                chislo = chislo / 3.2808399;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
            }
            else if (inputDimension == "yd")
            {
                if (outputDimension == "yd")
                    result = chislo;
                chislo = chislo / 1.0936133;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "cm")
                    result = chislo * 100;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;
                
            }
            else if (inputDimension == "cm")
            {
                if (outputDimension == "cm")
                    result = chislo;
                chislo = chislo / 100;
                if (outputDimension == "m")
                    result = chislo;
                else if (outputDimension == "mm")
                    result = chislo * 1000;
                else if (outputDimension == "yd")
                    result = chislo * 1.0936133;
                else if (outputDimension == "mi")
                    result = chislo * 0.000621371192;
                else if (outputDimension == "in")
                    result = chislo * 39.3700787;
                else if (outputDimension == "km")
                    result = chislo * 0.001;
                else if (outputDimension == "ft")
                    result = chislo * 3.2808399;

            }
            Console.WriteLine("{0:F8}",result);
        }
    }
}
