using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            String topBottom = new string('*', a);
            String side = '*' + new string(' ', a - 2) + '*';
            Console.WriteLine(topBottom);
            for (int i = 0; i < a - 2; ++i)
            {
                Console.WriteLine(side);
            }
            Console.WriteLine(topBottom);

        }
    }
}
