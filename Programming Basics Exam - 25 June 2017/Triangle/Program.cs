using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int height = (2 * n) + 1;
            char hashtag = '#';
            char dot = '.';
            char whiteSpace = ' ';
            int countOfDots = 1;
            int countOfHash = (2 * n) - 1;
            int countOfWhite = 1;
            string stringOfDots = string.Empty;
            string stringOfHash = string.Empty;
            string stringOfWhite = string.Empty;
            Console.WriteLine(new string(hashtag, width));
            for (int i = 0; i < (n / 2); i++)
            {
                stringOfDots = new string(dot, countOfDots);
                stringOfHash = new string(hashtag, countOfHash);
                stringOfWhite = new string(whiteSpace, countOfWhite);

                Console.WriteLine("{0}{1}{2}{1}{0}", stringOfDots, stringOfHash, stringOfWhite);
                countOfHash -= 2;
                countOfWhite += 2;
                countOfDots += 1;
            }
            string eye = "(@)";
            int eyeRowWhiteSpaces = (countOfWhite - 3) / 2;
            stringOfDots = new string(dot, countOfDots);
            stringOfHash = new string(hashtag, countOfHash);

            stringOfWhite = new string(whiteSpace, eyeRowWhiteSpaces);
            countOfWhite += 2;
            countOfDots += 1;
            countOfHash -= 2;
            Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", stringOfDots, stringOfHash, stringOfWhite, eye);
            for (int i = 0; i < n - (n / 2) - 1; i++)
            {
                stringOfDots = new string(dot, countOfDots);
                stringOfHash = new string(hashtag, countOfHash);
                stringOfWhite = new string(whiteSpace, countOfWhite);

                Console.WriteLine("{0}{1}{2}{1}{0}", stringOfDots, stringOfHash, stringOfWhite);

                countOfWhite += 2;
                if (i < n - (n / 2) - 2)
                    countOfDots += 1;
                countOfHash -= 2;
            }
            if(n!=2)
            countOfDots += 1;
            countOfHash = (2 * n) - 1;
            for (int i = 0; i < n; i++)
            {
                stringOfDots = new string(dot, countOfDots);
                stringOfHash = new string(hashtag, countOfHash);
                Console.WriteLine("{0}{1}{0}", stringOfDots, stringOfHash);
                countOfHash -= 2;
                countOfDots += 1;
            }
        }
    }
}
