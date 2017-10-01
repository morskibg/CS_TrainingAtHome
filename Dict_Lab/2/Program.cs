using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).OrderBy(x => x).ToList();
            Dictionary<double, int> wordsCount = new Dictionary<double, int>();
            foreach (var num in nums)
            {
                if (wordsCount.ContainsKey(num))
                {
                    wordsCount[num]++;
                }
                else
                {
                    wordsCount[num] = 1;
                }
            }
            foreach (var kvp in wordsCount)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
