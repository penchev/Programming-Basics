using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
                bonus = 5;
            else 
                bonus = 0.2 * score;
            if (score > 1000)
                bonus = 0.1 * score;

            if (score % 2 == 0)
                bonus = bonus + 1;
            else if (score % 5 == 0)
                bonus = bonus + 2;

            Console.WriteLine(bonus);
            Console.WriteLine(bonus+score);
        }
    }
}
