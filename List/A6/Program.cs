using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> sortedNums = new List<int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                sortedNums.Add(nums[i]);
                if(i == 0)
                {
                    continue;
                }

                for (int j = sortedNums.Count - 1; j > 0; --j)
                {
                    while (sortedNums[j] < sortedNums[j - 1])
                    {
                        int temp = sortedNums[j];
                        sortedNums[j] = sortedNums[j - 1];
                        sortedNums[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", sortedNums));
        }
    }
}
