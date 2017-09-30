using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plo4ki
{
    class Program
    {
        const double timeToPlace = 0.2;
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());
            double PlaceArea = N * N;
            double StoneArea = W * L;
            double SofaArea = M * O;
            double activePlaceArea = PlaceArea - SofaArea;
            double stoneQuantity = activePlaceArea / StoneArea;
            double totalTime = stoneQuantity * timeToPlace;
            Console.WriteLine(stoneQuantity.ToString("0.00"));
            Console.WriteLine(totalTime.ToString("0.00"));

        }
    }
}
