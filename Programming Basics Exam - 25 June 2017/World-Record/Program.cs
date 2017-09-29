using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double ivanTime = 0;
            double ivanNedostig = 0;

            ivanTime = metres * seconds;

            for (int i = 15; i <= metres; i = i + 15)
            {
                ivanTime = ivanTime + 12.5;
            }


            if (record <=ivanTime)
            {
                ivanNedostig = ivanTime - record;
                Console.WriteLine("No, he failed!He was {0:f2} seconds slower.", ivanNedostig);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded!The new world record is {0:f2} seconds.", ivanTime);
            }
        }
    }
}
