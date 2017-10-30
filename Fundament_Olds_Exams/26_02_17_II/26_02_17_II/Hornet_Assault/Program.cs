using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            for (int i = 0; i < beeHives.Count; ++i)
            {
                long hornetAttack = hornets.Sum();
                if (hornetAttack > beeHives[i])
                {
                    beeHives[i] = -1;
                }
                else
                {
                    beeHives[i] -= hornetAttack;
                    hornets.RemoveAt(0);
                    if (hornets.Count == 0)
                    {
                        break;
                    }
                    hornetAttack = hornets.Sum();
                }
            }
            if (beeHives.Sum() > 0)
            {
                foreach (var hive in beeHives.Where(x => x > 0))
                {
                    Console.Write(hive + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            Console.WriteLine();
        }
    }
}
