using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaFigures
{
    class Program
    {

        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0,b = 0;
            double a = double.Parse(Console.ReadLine());
            switch (figure)
            {
                case "square":
                    
                    result = a * a;
                    break;
                case "rectangle":                    
                    b = double.Parse(Console.ReadLine());
                    result = a * b;
                    break;
                case "circle":
                    result = Math.PI * a * a;
                    break;
                case "triangle":
                    b = double.Parse(Console.ReadLine());
                    result = a * b / 2;
                    break;
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
