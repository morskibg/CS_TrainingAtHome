using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void PrintTriangle(int inputNum)
        {
            for(int i = 1; i <= inputNum; ++i)
            {
                for(int j = 1; j <= i; ++j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = inputNum - 1; i > 0; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
