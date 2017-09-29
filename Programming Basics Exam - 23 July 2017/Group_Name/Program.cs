using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char glavna = char.Parse(Console.ReadLine());
            char malka1 = char.Parse(Console.ReadLine());
            char malka2 = char.Parse(Console.ReadLine());
            char malka3 = char.Parse(Console.ReadLine());
            int cifra = int.Parse(Console.ReadLine());
            int broqch = 0;

            for (char i = 'A'; i <= glavna; i++)
                for (char d = 'a'; d <= malka1; d++)
                    for (char l = 'a'; l <= malka2; l++)
                        for (char p = 'a'; p <= malka3; p++)
                            for (int s = 0; s <=cifra; s++)
                                broqch++;

            Console.WriteLine(broqch-1);







        }
    }
}
