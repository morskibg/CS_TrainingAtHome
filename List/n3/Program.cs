using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (int first in firstList)
            {
                while (secondList.Contains(first))
                {
                    secondList.Remove(first);
                }
            }
            int firstSum = firstList.Sum();
            int secondSum = secondList.Sum();
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes. Sum: {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
