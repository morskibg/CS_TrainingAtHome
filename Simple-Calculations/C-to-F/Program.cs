using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_to_F
{
    class Program
    {
        static double coef = (double)9/5;
        static void Main(string[] args)
        {
            
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * coef + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
