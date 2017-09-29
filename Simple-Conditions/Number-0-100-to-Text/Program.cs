using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondDigit = number % 10;
            string digit = "";

            if (secondDigit == 1)
                digit = "one";
            else if (secondDigit == 2)
                digit = "two";
            else if (secondDigit == 3)
                digit = "three";
            else if (secondDigit == 4)
                digit = "four";
            else if (secondDigit == 5)
                digit = "five";
            else if (secondDigit == 6)
                digit = "six";
            else if (secondDigit == 7)
                digit = "seven";
            else if (secondDigit == 8)
                digit = "eight";
            else if (secondDigit == 9)
                digit = "nine";

            if(number<0 || number>100)
                Console.WriteLine("invalid number");
            else if (number == 0)
                Console.WriteLine("zero");
            else if (number == 1)
                Console.WriteLine("one");
            else if (number == 2)
                Console.WriteLine("two");
            else if (number == 3)
                Console.WriteLine("three");
            else if (number == 4)
                Console.WriteLine("four");
            else if (number == 5)
                Console.WriteLine("five");
            else if (number == 6)
                Console.WriteLine("six");
            else if (number == 7)
                Console.WriteLine("seven");
            else if (number == 8)
                Console.WriteLine("eight");
            else if (number == 9)
                Console.WriteLine("nine");
            else if (number == 10)
                Console.WriteLine("ten");
            else if (number == 11)
                Console.WriteLine("eleven");
            else if (number == 12)
                Console.WriteLine("twelve");
            else if (number == 13)
                Console.WriteLine("thirteen");
            else if (number == 14)
                Console.WriteLine("fourteen");
            else if (number == 15)
                Console.WriteLine("fifteen");
            else if (number == 16)
                Console.WriteLine("sixteen");
            else if (number == 17)
                Console.WriteLine("seventeen");
            else if (number == 18)
                Console.WriteLine("eighteen");
            else if (number == 19)
                Console.WriteLine("nineteen");
            else if (number == 20)
                Console.WriteLine("twenty");
            else if (number>20 && number<30)
                Console.WriteLine("twenty "+ digit);
            else if (number == 30)
                Console.WriteLine("thirty");
            else if (number > 30 && number < 40)
                Console.WriteLine("thirty " + digit);
            else if (number == 40)
                Console.WriteLine("forty");
            else if (number > 40 && number < 50)
                Console.WriteLine("forty " + digit);
            else if (number == 50)
                Console.WriteLine("fifty");
            else if (number > 50 && number < 60)
                Console.WriteLine("fifty " + digit);
            else if (number == 60)
                Console.WriteLine("sixty");
            else if (number > 60 && number < 70)
                Console.WriteLine("sixty " + digit);
            else if (number == 70)
                Console.WriteLine("seventy");
            else if (number > 70 && number < 80)
                Console.WriteLine("seventy " + digit);
            else if (number == 80)
                Console.WriteLine("eighty");
            else if (number > 80 && number < 90)
                Console.WriteLine("eighty " + digit);
            else if (number == 90)
                Console.WriteLine("ninety");
            else if (number > 90 && number < 100)
                Console.WriteLine("ninety " + digit);
            else if (number == 100)
                Console.WriteLine("one hundred");
        }
    }
}
