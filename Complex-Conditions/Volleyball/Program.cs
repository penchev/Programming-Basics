using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double praznichni = 0;
            double weekendski = 0;
            double result = 0, resultLeap = 0 ;
            double weekends = 48 - h;

            praznichni = (p * 2) / 3;
            weekendski = (weekends * 3) / 4;
            result = praznichni + weekendski + h;

            if (year == "leap")
            {
                resultLeap = (15 * result) / 100;
                result = result + resultLeap;
            }

            Console.WriteLine("{0:0}",result);
        }
    }
}
