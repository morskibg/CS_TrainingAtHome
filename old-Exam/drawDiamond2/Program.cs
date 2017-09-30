using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawDiamond2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middle = 3 * n;
            for (int i = 0; i < n; ++i)
            {               
                if(i ==0)
                {
                    Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', middle));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new String('.', n - i), new String('.', middle ));
                    middle += 2;
                }                
            }
            Console.WriteLine("{0}", new String('*', 5 * n));
            middle = 5 * n - 4 ;
            for(int i = 1; i <= 2 * n; ++i)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', i), new String('.', middle));
                middle -= 2;
            }
            middle += 2;
            Console.WriteLine("{0}{1}{0}", new String('.', 2 * n + 1), new String('*', middle));
        }
    }
}
