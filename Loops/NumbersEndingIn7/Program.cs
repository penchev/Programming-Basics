using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int currentNumber = 7; currentNumber <=997; currentNumber=currentNumber+10)
                Console.WriteLine(currentNumber);
            
        }
    }
}
