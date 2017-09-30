using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            double bars = beats / 4.0;
            bars = Math.Round(bars, 1);
            int totalMinutes = (int)Math.Floor(beats / (BPM / 60.0));
            int hours = 0;
            if(totalMinutes > 60)
            {
                hours = totalMinutes % 60;
                totalMinutes -= (hours * 60);
            }
            else if(totalMinutes == 60)
            {
                hours = 1;
                totalMinutes = 0;
            }
            Console.WriteLine("{0} bars - {1}m {2}s",bars, hours, totalMinutes);
           
        }
    }
}
