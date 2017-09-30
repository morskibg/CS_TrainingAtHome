using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_to_deg
{
    class Program
    {
        const double coef = 180 / Math.PI;
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine((int)(rad * coef));
        }
    }
}
