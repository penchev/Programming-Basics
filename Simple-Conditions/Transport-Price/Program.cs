using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometres = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double priceTrain = 0, priceTaxi = 0, priceBus = 0;

            if (dayNight == "day")
            {
                priceTaxi = 0.7 + kilometres * 0.79;
            }
            else if (dayNight == "night")
            {
                priceTaxi = 0.7 + kilometres * 0.9;
            }
            
            if (kilometres >= 20)
            {
                priceBus = kilometres * 0.09;
            }
            else Console.WriteLine(priceTaxi);

            if (kilometres >= 100)
            {
                priceTrain = kilometres * 0.06;
                if(priceTrain<priceBus)
                    Console.WriteLine(priceTrain);
                else Console.WriteLine(priceBus);
            }else if(priceBus<priceTaxi && kilometres>=20)
                Console.WriteLine(priceBus);
            
        }
    }
}
