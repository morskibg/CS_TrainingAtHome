using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("+{0}+{1}", new String('~', n - 2), new String('.', 2 * n + 1));
            for(int i = 0; i < 2 * n + 1; ++i)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new String('.', i), new String('~', n - 2), new String('.', 2 * n - i));
            }
            for (int i = 0; i < 2 * n + 1; ++i)
            {
                Console.WriteLine("{0}\\{2}|{1}|", new String('.', i), new String('~', n - 2), new String('.', 2 * n - i));
            }
            Console.WriteLine("{1}+{0}+", new String('~', n - 2), new String('.', 2 * n + 1));
        }
    }
}
