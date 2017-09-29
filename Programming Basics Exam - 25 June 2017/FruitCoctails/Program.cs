using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double price = 0;
            double otstupka = 0;

            if (size == "small")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 112 * number;
                        break;
                    case "Mango":
                        price = 73.32 * number;
                        break;
                    case "Pineapple":
                        price = 42.10 * 2 * number;
                        break;
                    case "Raspberry":
                        price = 40 * number;
                        break;
                    default:
                        break;
                }

            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 5 * 28.7 * number;
                        break;
                    case "Mango":
                        price = 5 * 19.6 * number;
                        break;
                    case "Pineapple":
                        price = 24.8 * 5 * number;
                        break;
                    case "Raspberry":
                        price = 15.2 * 5 * number;
                        break;
                    default:
                        break;
                }
            }

            if (price >= 400 && price <= 1000)
            {
                otstupka = price * 0.15;
                price = price - otstupka;
            }
            else if (price > 1000)
            {
                otstupka = price * 0.5;
                price = price - otstupka;
            }
            Console.WriteLine("{0:f2} lv.",price);
        }
    }
}
