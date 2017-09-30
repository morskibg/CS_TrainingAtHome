using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevCoin = int.Parse(Console.ReadLine());
            int twoLevaCoin = int.Parse(Console.ReadLine());
            int fiveLevaPaper = int.Parse(Console.ReadLine());
            int totalSum  = int.Parse(Console.ReadLine());
            for(int ones = 0; ones <= oneLevCoin; ++ones)
            {
                for(int twos = 0; twos <= twoLevaCoin; ++twos)
                {
                    for(int fives = 0; fives <= fiveLevaPaper; ++ fives)
                    {
                        if(ones * 1 + twos * 2 + fives * 5 == totalSum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", ones, twos, fives, totalSum);
                        }
                    }

                }
            }
        }
    }
}
