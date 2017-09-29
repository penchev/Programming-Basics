using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double holidayPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzle = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());
            int sum = 0;
            double puzzleCash = 0, talkingDollsCash = 0, teddyBearsCash = 0, minionsCash = 0, trucksCash = 0;
            double totalWin = 0, moneyLeft = 0, moneyNeeded = 0 ;

            puzzleCash = numberOfPuzzle * 2.6;
            talkingDollsCash = numberOfTalkingDolls * 3;
            teddyBearsCash = numberOfTeddyBears * 4.10;
            minionsCash = numberOfMinions * 8.20;
            trucksCash = numberOfTrucks * 2;
            totalWin = puzzleCash + talkingDollsCash + teddyBearsCash + minionsCash + trucksCash;
            sum = numberOfMinions + numberOfPuzzle + numberOfTalkingDolls + numberOfTeddyBears + numberOfTrucks;
            if (sum >= 50)
            {
                totalWin = totalWin - (totalWin * 0.25);
            }

            totalWin = totalWin - (totalWin * 0.10);

            if (totalWin >= holidayPrice)
            {
                moneyLeft = totalWin - holidayPrice;
                Console.WriteLine("Yes! {0:f2} lv left.", moneyLeft);
            }
            else
            {
                moneyNeeded = holidayPrice - totalWin;
                Console.WriteLine("Not enough money! {0:f2} lv needed.", moneyNeeded);
            }
        }
    }
}
