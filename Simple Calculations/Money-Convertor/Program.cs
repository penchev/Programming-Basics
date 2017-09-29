using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            var fromCurrency = Console.ReadLine();
            var toCurrency = Console.ReadLine();
            double ocMoney = 0;
            if (fromCurrency == "BGN")
            {
                if (toCurrency == "USD")
                    ocMoney = money / 1.79549;
                else if (toCurrency == "GBP")
                    ocMoney = money / 2.53405;
                else if (toCurrency == "EUR")
                    ocMoney = money / 1.95583;
            }else if (fromCurrency == "USD")
            {
                ocMoney = money * 1.79549;    
                if (toCurrency == "EUR")
                    ocMoney = ocMoney / 1.95583;
                else if (toCurrency == "GBP")
                    ocMoney = ocMoney / 2.53405;
                
            }else if (fromCurrency == "EUR")
            {
                ocMoney = money * 1.95583;
                if (toCurrency == "USD")
                    ocMoney = ocMoney / 1.79549;
                else if(toCurrency=="GBP")
                    ocMoney = ocMoney / 2.53405;
            }else if (fromCurrency == "GBP")
            {
                ocMoney = money * 2.53405;
                if (toCurrency == "USD")
                    ocMoney = ocMoney / 1.79549;
                else if(toCurrency=="EUR")
                    ocMoney = ocMoney / 1.95583;
            }
            Console.WriteLine($"{Math.Round(ocMoney,2)} {toCurrency}");
        }
    }
}
