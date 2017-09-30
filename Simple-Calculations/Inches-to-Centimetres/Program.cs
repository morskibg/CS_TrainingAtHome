using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimetres
{
    
    class Program
    {
        const double i_to_c = 2.54;
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());           
            double res = input * i_to_c;
            Console.WriteLine(res);
        }
    }
}
