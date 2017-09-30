using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n / 2; ++i)
            {
                Console.WriteLine("{1}x{0}x{1}", new String(' ', n - 2 - 2 * i), new String(' ', i));
            }
            Console.WriteLine("{0}x", new String(' ', n / 2));
            for(int i = 0; i < n/2; ++i)
            {
                Console.WriteLine("{1}x{0}x{1}", new String(' ', 1 + 2 * i), new String(' ', n / 2 - (i + 1)));
               // Console.WriteLine(i);
            }
        }
    }
}
