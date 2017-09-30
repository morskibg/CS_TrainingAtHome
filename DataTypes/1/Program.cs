using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; ++i)
            {
                int sum = 0;
                int currNum = i;
                while (currNum != 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }               
                if (sum == 7 || sum == 5 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
            
        }
    }
}
