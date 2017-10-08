using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftNums = nums.Take(nums.Length / 4).Reverse().ToArray();
            int[] rightNums = nums.Skip(nums.Length / 4 * 3).Reverse().ToArray();
            int[] downNums = nums.Skip(nums.Length / 4).Take(nums.Length / 2).ToArray();
            int[] upNums = leftNums.Concat(rightNums).ToArray();
            int[] result = downNums.Select((val, i) => val + upNums[i]).ToArray();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
