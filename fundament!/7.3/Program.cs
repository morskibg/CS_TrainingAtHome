using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double megaPix = Math.Round(width * height / 1000000.0, 1);           
            Console.WriteLine(megaPix);
        }
    }
}
