using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());
            double beerPrice = 0, winePrice = 0, rakiaPrice = 0,result = 0;

            rakiaPrice = 0.5 * whiskeyPrice;
            winePrice = rakiaPrice-(0.4 * rakiaPrice);
            beerPrice = rakiaPrice-(0.8 * rakiaPrice);

            result = whiskeyPrice * whiskeyQuantity + beerPrice * beerQuantity + winePrice * wineQuantity + rakiaPrice * rakiaQuantity;

            Console.WriteLine("{0:f2}",result);

        }
    }
}
