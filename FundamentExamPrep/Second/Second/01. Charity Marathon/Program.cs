using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long totalRunners = runnersCount <= trackCapacity * marathonDays ? runnersCount : trackCapacity * marathonDays;
            
            long totalDistance = totalRunners * laps * lapLength;
            double totalRaisedMoney = moneyPerKm * totalDistance / 1000;
            Console.WriteLine($"Money raised: {totalRaisedMoney:f2}");

        }
    }
}
