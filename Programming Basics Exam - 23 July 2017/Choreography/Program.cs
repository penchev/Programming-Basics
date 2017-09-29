using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberOfSteps = double.Parse(Console.ReadLine());
            double numberOfDancers = double.Parse(Console.ReadLine());
            double numberOfDaysForLearning = double.Parse(Console.ReadLine());

            double stepsPerDay = 0;
            double percentPerDancer = 0;

            stepsPerDay = Math.Ceiling((numberOfSteps / numberOfDaysForLearning) / numberOfSteps*100);
            percentPerDancer = stepsPerDay / numberOfDancers;

            if(stepsPerDay<=13)
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.",percentPerDancer);
            else
                Console.WriteLine("No, They will not succeed in that goal! " +
                    "Required {0:f2}% steps to be learned per day.", percentPerDancer);
        }
    }
}
