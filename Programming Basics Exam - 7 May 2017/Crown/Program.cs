using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) - 1;
            int height = (n / 2) + 4;
            char at = '@';
            char interval = ' ';
            char star = '*';
            char dot = '.';
            int starCounter = 1;
            int dotCounter = 1;
            int intervalCounter = 1;


            Console.Write(at);
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(interval);
            }
            Console.Write(at);
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(interval);
            }
            Console.WriteLine(at);
            Console.Write(new string(star,2));
            Console.Write(new string(interval,n-3));
            Console.Write(new string(star, 1));
            Console.Write(new string(interval, n - 2));
            Console.WriteLine(new string(star, 2));
            intervalCounter = n - 5;
            starCounter++;
            for (int i = 0; i < n/2-1; i++)
            {
                Console.Write("{0}{1}{0}{2}", star, new string(dot, dotCounter),new string(interval,n-5));
                dotCounter++;
                interval--;
            }
        }

    }
}
