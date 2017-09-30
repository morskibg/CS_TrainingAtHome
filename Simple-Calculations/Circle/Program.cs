using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159265359;
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area   {0}", pi * r * r);
            Console.WriteLine("Perimeter = {0}", 2 * pi * r);
        }
    }
}
