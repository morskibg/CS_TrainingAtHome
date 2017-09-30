using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawFortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int partOne = n / 2;
            Console.WriteLine("/{0}\\{1}/{0}\\", new String('^',n / 2), new String('_', 2 * n - 2 * (2 + partOne)) );
            for(int i = 1; i < n - 2; ++i)
            {
                Console.WriteLine("|{0}|",new String(' ', 2 * n - 2 ));
            }
            if(n < 4)
            {
                Console.WriteLine("|{0}|", new String(' ', 2 * n - 2));
            }
            else
            {
                Console.WriteLine("|{0}{1}{0}|", new String(' ', partOne + 1), new String('_', 2 * n - 2 * (2 + partOne)));               
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new String('_', n / 2), new String(' ', 2 * n - 2 * (2 + partOne)));
        }
    }
}
