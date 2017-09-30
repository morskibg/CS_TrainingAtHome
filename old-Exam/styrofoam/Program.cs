using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var area = double.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());
            var areaStryro = double.Parse(Console.ReadLine());
            var packetPrice = double.Parse(Console.ReadLine());
            var totalWindowArea = windows * 2.4;
            var realArea = (area - totalWindowArea) * 1.1;
            var neededPackages = realArea / areaStryro;
            neededPackages =  Math.Ceiling(neededPackages);
            var totalMoney = neededPackages * packetPrice;
            var dif = budget - totalMoney;
            if(dif >= 0)
            {
                Console.WriteLine("Spent: {0:F2}", totalMoney);
                Console.WriteLine("Left: {0:F2}", dif);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", dif * -1);
            }
            //Console.WriteLine(neededPackages);
        }
    }
}
