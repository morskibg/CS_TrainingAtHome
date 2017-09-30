using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 1;
            if(num > 1000)
            {
                bonus = num * 0.1;
            }
            else if(num > 100)
            {
                bonus = num * 0.2;
            }
            else
            {
                bonus = 5;
            }
            if(num % 2 == 0)
            {
                ++bonus;
            }
            if(num % 5 == 0 && num % 10 != 0)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
