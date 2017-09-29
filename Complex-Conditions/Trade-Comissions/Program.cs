using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double result = -1;
            switch (town)
            {
                case "sofia":
                    if (s >= 0 && s <= 500)
                        result = 0.05 * s;
                    else if (s > 500 && s <= 1000)
                        result = 0.07 * s;
                    else if (s > 1000 && s <= 10000)
                        result = 0.08 * s;
                    else if (s > 10000)
                        result = 0.12 * s;
                    else Console.WriteLine("error");
                    break;
                case "varna":
                    if (s >= 0 && s <= 500)
                        result = 0.045 * s;
                    else if (s > 500 && s <= 1000)
                        result = 0.075 * s;
                    else if (s > 1000 && s <= 10000)
                        result = 0.1 * s;
                    else if (s > 10000)
                        result = 0.13 * s;
                    else Console.WriteLine("error");
                    break;
                case "plovdiv":
                    if (s >= 0 && s <= 500)
                        result = 0.055 * s;
                    else if (s > 500 && s <= 1000)
                        result = 0.08 * s;
                    else if (s > 1000 && s <= 10000)
                        result = 0.12 * s;
                    else if (s > 10000)
                        result = 0.145 * s;
                    else Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if(result > 0) Console.WriteLine("{0:0.00}",result);
        }
    }
}
