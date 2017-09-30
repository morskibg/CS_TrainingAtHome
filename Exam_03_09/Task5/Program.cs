using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n ; ++i)
            {
                if(i != n - 1)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new String('.', i), new String('.', n - i));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new String('.', i), new String('*', 5));

                }
                
            }
            Console.WriteLine(new String('*', 2 * n + 3));
            for (int i = n - 1 ; i >= 0; --i)
            {
                if (i != n - 1)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new String('.', i), new String('.', n - i));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new String('.', i), new String('*', 5));
                }
            }
        }
    }
}
