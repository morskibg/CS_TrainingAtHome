using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grape
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var dobiv = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());
            double totalGrape = area * dobiv - brak;
            double forRaki = totalGrape * 0.45;
            Console.WriteLine("{0:F2}",forRaki / 7.5 * 9.8);
            Console.WriteLine("{0:F2}",(totalGrape - forRaki) * 1.5);
        }
    }
}
