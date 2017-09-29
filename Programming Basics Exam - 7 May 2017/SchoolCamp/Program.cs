using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string gender = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double pricePerNight=0,totalMoney;
            string sport = string.Empty;

            if (season == "winter")
            {
                if (gender == "boys")
                {
                    pricePerNight = 9.60;
                    sport = "Judo";
                }
                else if (gender == "girls")
                {
                    pricePerNight = 9.60;
                    sport = "Gymnastics";
                }
                else if (gender == "mixed")
                {
                    pricePerNight = 10;
                    sport = "Ski";
                }
            }
            else if (season == "spring")
            {
                if (gender == "boys")
                {
                    pricePerNight = 7.20;
                    sport = "Tennis";
                }
                else if (gender == "girls")
                {
                    pricePerNight = 7.20;
                    sport = "Athletics";
                }
                else if (gender == "mixed")
                {
                    pricePerNight = 9.50;
                    sport = "Cycling";
                }
            }
            else if (season == "summer")
            {
                if (gender == "boys")
                {
                    pricePerNight = 15;
                    sport = "Football";
                }
                else if (gender == "girls")
                {
                    pricePerNight = 15;
                    sport = "Volleyball";
                }
                else if (gender == "mixed")
                {
                    pricePerNight = 20;
                    sport = "Swimming";
                }
            }
            totalMoney = pricePerNight * numberOfNights * numberOfStudents;
            if (numberOfStudents >= 50)
            {
                totalMoney = totalMoney - (totalMoney * 0.5);
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
                totalMoney = totalMoney - (totalMoney * 0.15);
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
                totalMoney = totalMoney - (totalMoney * 0.05);

            Console.WriteLine("{0} {1:f2} lv.",sport,totalMoney);
        }
    }
}
