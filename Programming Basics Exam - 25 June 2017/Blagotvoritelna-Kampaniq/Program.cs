using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagotvoritelna_Kampaniq
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int numberOfConfectioners = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());

            double cakesIncome = 0,pancakesIncome=0,wafflesIncome=0,result=0;
            double outcome = 0;

            cakesIncome = numberOfConfectioners * numberOfCakes * 45 ;
            pancakesIncome = numberOfConfectioners * numberOfPancakes * 5.8;
            wafflesIncome = numberOfConfectioners * numberOfWaffles * 3.20;
            result = (cakesIncome + pancakesIncome + wafflesIncome)*days;
            
            outcome = result * 0.125 ;
            result = result - outcome;
            Console.WriteLine("{0:f2}", result);
            
            
        }
    }
}
