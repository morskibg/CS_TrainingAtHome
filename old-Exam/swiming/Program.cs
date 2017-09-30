using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swiming
{
    class Program
    {
        const double delayLength = 15.0;
        const double delayTime = 12.5;
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double metersToSwim = double.Parse(Console.ReadLine());
            double oneMeterSec = double.Parse(Console.ReadLine());
            int delayInervals = (int)metersToSwim / (int)delayLength;
            double acumulatedDelay = delayInervals * delayTime;
            double totalSwimTime = metersToSwim * oneMeterSec + acumulatedDelay;
            if(totalSwimTime < recordSec)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalSwimTime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", totalSwimTime - recordSec);
            }
        }
    }
}
