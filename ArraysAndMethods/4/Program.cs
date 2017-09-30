using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int FindNthDigit(long number, int index)
        {
            for(int i = 0; i < index - 1; ++i)
            {
                number /= 10;
            }
            int digit = (int)number % 10;
            return digit;
        }
        static void Main(string[] args)
        {
            long bigNum = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(bigNum, position));
        }
    }
}
