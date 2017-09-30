using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            int totalSeconds = time1 + time2 + time3;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            Console.WriteLine("{0}:{1}", minutes, seconds.ToString("00"));
        }
    }
}
