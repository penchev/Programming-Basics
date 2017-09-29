using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfTheDancers = int.Parse(Console.ReadLine());
            double numberOfPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double moneyPrice = 0;
            double blagotvoritelnost = 0;
            double moneyLeft = 0;
            double moneyPerDancer = 0;

            if (place == "bulgaria")
            {
                moneyPrice = numberOfPoints * numberOfTheDancers;
                if (season == "summer")
                    moneyPrice = moneyPrice - (moneyPrice * 0.05);
                else if (season == "winter")
                    moneyPrice = moneyPrice - (moneyPrice * 0.08);
            }
            else if (place == "abroad")
            {
                moneyPrice = numberOfTheDancers * numberOfPoints + (0.5 * numberOfPoints * numberOfTheDancers);
                if (season == "summer")
                    moneyPrice = moneyPrice - (moneyPrice * 0.1);
                else if (season == "winter")
                    moneyPrice = moneyPrice - (moneyPrice * 0.15);
            }
            blagotvoritelnost = 0.75 * moneyPrice;
            moneyLeft = moneyPrice - blagotvoritelnost;
            moneyPerDancer = moneyLeft / numberOfTheDancers;

            Console.WriteLine("Charity - {0:f2}",blagotvoritelnost);
            Console.WriteLine("Money per dancer - {0:f2}",moneyPerDancer);
        }
    }
}
