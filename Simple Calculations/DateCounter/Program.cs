using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "dd-MM-yyyy",CultureInfo.InvariantCulture);
            date=date.AddDays(1000);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
