using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            TimeSpan initialTime = new TimeSpan(int.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2]));
            double steps = double.Parse(Console.ReadLine()) % 86400;
            double timeForEachStep = double.Parse(Console.ReadLine()) % 86400;
            double totalTimeInDays = (steps * timeForEachStep) / (60 * 60 * 24);
            TimeSpan stepTime = TimeSpan.FromDays(totalTimeInDays);
            TimeSpan resultTime = initialTime + stepTime;
            Console.WriteLine($"Time Arrival: {resultTime.Hours.ToString("00")}:{resultTime.Minutes.ToString("00")}:{resultTime.Seconds.ToString("00")}");


            int t = 0;
        }
    }
}
