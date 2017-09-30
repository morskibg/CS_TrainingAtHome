using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            //byte byteVar = (byte)n;
            //if (n / 256 > 0)
            //{
            //    int overflowed = n / 256;
            //    byteVar = (byte)(n - (overflowed * 256));
            //    Console.WriteLine(byteVar);
            //    Console.WriteLine("Overflowed {0} times", overflowed);
            //}
            //else
            //{
            //    Console.WriteLine(byteVar);
            //}
            decimal teraB = (decimal)(1024 * 1024 * 1024 * 1024 * 8 * n);
            Console.WriteLine(teraB);
        }
    }
}
