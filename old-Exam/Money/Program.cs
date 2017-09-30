using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        const double bitToLeva = 1168.0;
        const double chinaToUsd = 0.15;
        const double usdToLeva = 1.76;
        const double eurToLeva = 1.95;
        static void Main(string[] args)
        {
            int bitkoins = int.Parse(Console.ReadLine());
            double chinaYans = double.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double leva = bitkoins * bitToLeva;
            double usd = chinaYans * chinaToUsd;
            leva += (usd * usdToLeva);
            double euro = leva / eurToLeva;
            euro -= euro * (interest / 100);
            Console.WriteLine(euro.ToString("0.00"));
        }
    }
}
