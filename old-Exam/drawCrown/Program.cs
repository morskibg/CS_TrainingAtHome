using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawCrown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int heigth = n / 2 + 4;
            int empty = n - 2;
            Console.WriteLine("@{0}@{0}@", new string(' ', empty)); // top(first) line
            --empty;
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine("*{0}*{1}", new string('.', i), new string(' ', empty));
            }
            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
