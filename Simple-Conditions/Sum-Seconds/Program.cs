using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sum = time1 + time2 + time3;

            if (sum >= 0 && sum <= 59)
                if (sum < 10)
                    Console.WriteLine("0:0" + sum);
                else
                    Console.WriteLine("0:" + sum);
            else
            if (sum >= 60 && sum <= 119)
            {
                sum = sum - 60;
                if (sum < 10)
                    Console.WriteLine("1:0" + sum);
                else
                    Console.WriteLine("1:" + sum);
            }
            else
            {
                if (sum >= 120 && sum <= 179)
                    sum = sum - 120;
                if (sum < 10)
                    Console.WriteLine("2:0" + sum);
                else
                    Console.WriteLine("2:" + sum);
            }

        }
    }
}
