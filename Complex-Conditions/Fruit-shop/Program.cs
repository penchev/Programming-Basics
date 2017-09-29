using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            var price = -1.0;

            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    if (fruit == "banana")
                        price = 2.5;
                    else if (fruit == "apple")
                        price = 1.2;
                    else if (fruit == "orange")
                        price = 0.85;
                    else if (fruit == "grapefruit")
                        price = 1.45;
                    else if (fruit == "kiwi")
                        price = 2.7;
                    else if (fruit == "pineapple")
                        price = 5.5;
                    else if (fruit == "grapes")
                        price = 3.85;
                    else Console.WriteLine("error");
                    break;
                case "saturday":
                case "sunday":
                    if (fruit == "banana")
                        price = 2.7;
                    else if (fruit == "apple")
                        price = 1.25;
                    else if (fruit == "orange")
                        price = 0.9;
                    else if (fruit == "grapefruit")
                        price = 1.6;
                    else if (fruit == "kiwi")
                        price = 3;
                    else if (fruit == "pineapple")
                        price = 5.6;
                    else if (fruit == "grapes")
                        price = 4.2;
                    else Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if(price>0)
                Console.WriteLine(quantity*price);
            

        }
    }
}
