using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int height = 4 * n + 4;
            int dotNumber = 0, ampNumber = n / 2 + 1;
            char dot = '.';
            char amp = '~';
            int rightDotNumber = 3 * n + 1 - n;
            Console.Write("+");
            int broqch = 0;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write("~");
                broqch++;
            }
            Console.Write("+");
            Console.WriteLine(new string(dot, rightDotNumber + 1));

            for (int row = 0; row < height / 2; row++)
            {

                Console.Write("|");
                Console.Write("{0}\\{1}\\{2}", new string(dot, dotNumber), new string(amp, ampNumber), new string(dot, rightDotNumber));
                rightDotNumber--;
                dotNumber++;
                Console.WriteLine();
            }

            dotNumber = 0;
            rightDotNumber = 3 * n + 1 - n;
            for (int row = 0; row < height / 2; row++)
            {
                Console.Write("{0}\\{1}|{2}|", new string(dot, dotNumber), new string(dot, rightDotNumber),new string(amp,broqch));
                rightDotNumber--;
                dotNumber++;
                Console.WriteLine();
            }
        }
    }
}
