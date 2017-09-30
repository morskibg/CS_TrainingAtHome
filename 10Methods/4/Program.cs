using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void PrintFilledSquare(int inputNum)
        {
            PrintHeaderFooter(inputNum);
            
            for(int i = 0; i < inputNum - 2; ++i)
            {
                Console.Write("-");
                for (int j = 1; j <= inputNum - 1; ++j)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
            
            PrintHeaderFooter(inputNum);
        }
        static void PrintHeaderFooter(int inputNum)
        {
            Console.WriteLine("{0}", new string('-', 2 * inputNum));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }
    }
}
