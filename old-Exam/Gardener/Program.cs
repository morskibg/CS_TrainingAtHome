using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener
{
    class Program
    {
        const double rate = 1.94;
        static void Main(string[] args)
        {
            var VegPriceInLeva = double.Parse(Console.ReadLine());
            var FruitPriceInLeva = double.Parse(Console.ReadLine());
            var VegKilos = double.Parse(Console.ReadLine());
            var FruitKilos = double.Parse(Console.ReadLine());
            double result = (VegKilos * VegPriceInLeva + FruitKilos * FruitPriceInLeva) / rate;
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
