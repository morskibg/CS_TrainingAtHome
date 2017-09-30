using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i = 1; i < nums.Length; ++i)
            {
                for(int j = i; j > 0; --j)
                {
                    while(nums[j] < nums[j - 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
