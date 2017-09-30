using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3step
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            double sqrt = Math.Sqrt(num);
            if(num < 2)
            {
                isPrime = false;
            }
            else
            {
                for(int i = 2; i <= (int)sqrt; ++i)
                {
                    if(num % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
