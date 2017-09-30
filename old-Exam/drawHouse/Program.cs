using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = false;
            if(n % 2 == 0)
            {
                isEven = true;
            }
            int firstEvenDash = n / 2 - 1;
            int firstOddDash = n / 2;
            for (int i = 0; i < n; ++i)
            {
                if (i == 0)
                {
                    if (isEven)
                    {
                        Console.WriteLine("{0}**{0}", new String('-', firstEvenDash));
                        --firstEvenDash;
                    }
                    else
                    {
                        Console.WriteLine("{0}*{0}", new String('-', firstOddDash));
                        --firstOddDash;
                    }
                }
                else if (i == n - 1)
                {
                    Console.WriteLine("|{0}|", new String('*', n - 2));
                }
                else if(isEven && firstEvenDash > 0)
                {
                    Console.WriteLine("{0}{1}{0}", new String('-', firstEvenDash), new String('*', n - 2 * firstEvenDash));
                    --firstEvenDash;
                }
                else if(!isEven && firstOddDash > 0)
                {
                    Console.WriteLine("{0}{1}{0}", new String('-', firstOddDash), new String('*', n - 2 * firstOddDash));
                    --firstOddDash;
                }
                else if(firstOddDash == 0 || firstEvenDash == 0)
                {
                    Console.WriteLine("{0}", new String('*', n));
                    firstEvenDash = -1;
                    firstOddDash = -1;
                }
                else
                {
                    Console.WriteLine("|{0}|", new String('*', n - 2));
                }
            }

        }
    }
}
