using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAward
{
    class Program
    {
        static void Main(string[] args)
        {

            int parts = int.Parse(Console.ReadLine());
            double award = double.Parse(Console.ReadLine());
            int counter = 1;
            double temporaryMoney = 0,result =0;
            for (int i = 0; i < parts; i++, counter++)
            {

                int pointsPerPart = int.Parse(Console.ReadLine());

                if (counter % 2 == 0)
                {
                    temporaryMoney = pointsPerPart * 2;
                    temporaryMoney = temporaryMoney * award;
                }
                else
                {
                    temporaryMoney = pointsPerPart;
                    temporaryMoney = temporaryMoney * award;
                }
                result = result + temporaryMoney;
            }

            Console.WriteLine("The project prize was {0:f2} lv.",result);
        }
    }
}
