using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        struct Point
        {
            public double x;
            public double y;
        }
        struct Rectangle
        {
            public Point V1;
            public Point V2;
        }
        static void Main(string[] args)
        {
            Rectangle rect;
            rect.V1.x = double.Parse(Console.ReadLine());
            rect.V1.y = double.Parse(Console.ReadLine());
            rect.V2.x = double.Parse(Console.ReadLine());
            rect.V2.y = double.Parse(Console.ReadLine());
            double a = Math.Max(rect.V1.x, rect.V2.x) - Math.Min(rect.V1.x, rect.V2.x);
            double b = Math.Max(rect.V1.y, rect.V2.y) - Math.Min(rect.V1.y, rect.V2.y);
            double perim = 2 * (a + b);
            double area = a * b;
            Console.WriteLine(area);
            Console.WriteLine(perim);
        }
    }
}
