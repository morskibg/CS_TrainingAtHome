using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonach
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fib = 0;
            int prevFib = 2;
            int prevPrevFib = 1;
            if(num < 2)
            {
                Console.WriteLine(prevPrevFib);
            }
            else if(num == 2)
            {
                Console.WriteLine(prevFib);
            }
            else
            {
                for(int i = 3; i <= num; ++i)
                {
                    fib = prevFib + prevPrevFib;
                    prevPrevFib = prevFib;
                    prevFib = fib;

                }
                Console.WriteLine(fib);
            }
        }
    }
}
