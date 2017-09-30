using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());           
            for (int i = 1; i <= num; ++i)
            {
                int currNum = i;
                int sum = 0;
                while (currNum > 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }
                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);               
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);                
            }
        }
    }
}
