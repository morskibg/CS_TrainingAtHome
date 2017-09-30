using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = nums.First();
            int last = nums.Last();
            nums.Reverse();
            nums[0] = start;
            nums[nums.Count - 1] = last;
            Console.WriteLine(String.Join(" ", nums));

        }
    }
}
