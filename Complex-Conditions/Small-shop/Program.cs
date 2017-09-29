using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string product = Console.ReadLine();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
                switch (town)
                {
                    case "sofia":
                        Console.WriteLine(quantity * 0.5);
                        break;
                    case "plovdiv":
                        Console.WriteLine(quantity * 0.4);
                        break;
                    case "varna":
                        Console.WriteLine(quantity * 0.45);
                        break;
                    default:
                        break;
                }
            else if (product == "water")
                switch (town)
                {
                    case "sofia":
                        Console.WriteLine(quantity * 0.8);
                        break;
                    case "plovdiv":
                        Console.WriteLine(quantity * 0.7);
                        break;
                    case "varna":
                        Console.WriteLine(quantity * 0.7);
                        break;
                    default:
                        break;
                }
            else if (product == "beer")
                switch (town)
                {
                    case "sofia":
                        Console.WriteLine(quantity * 1.20);
                        break;
                    case "plovdiv":
                        Console.WriteLine(quantity * 1.15);
                        break;
                    case "varna":
                        Console.WriteLine(quantity * 1.10);
                        break;
                    default:
                        break;
                }
            else if (product == "sweets")
                switch (town)
                {
                    case "sofia":
                        Console.WriteLine(quantity * 1.45);
                        break;
                    case "plovdiv":
                        Console.WriteLine(quantity * 1.30);
                        break;
                    case "varna":
                        Console.WriteLine(quantity * 1.35);
                        break;
                    default:
                        break;
                }
            else if (product == "peanuts")
                switch (town)
                {
                    case "sofia":
                        Console.WriteLine(quantity * 1.60);
                        break;
                    case "plovdiv":
                        Console.WriteLine(quantity * 1.50);
                        break;
                    case "varna":
                        Console.WriteLine(quantity * 1.55);
                        break;
                    default:
                        break;
                }
        }
    }
}
