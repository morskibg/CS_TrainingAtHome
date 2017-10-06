using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            bool isFounded = false;
            for(int i = 0; i < nums.Length - 1; ++i)
            {
                for(int j = 0; j < nums.Length; ++j)
                {
                    if (i < j)
                    {
                        long currNum = nums[i] + nums[j];
                        if (nums.Contains(currNum))
                        {
                            Console.WriteLine($"{nums[i]} + {nums[j]} == {currNum}");
                            isFounded = true;
                        }
                    }
                    
                }
            }
            if (!isFounded)
            {
                Console.WriteLine("No");
            }
        }
    }
}
