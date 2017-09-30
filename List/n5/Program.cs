using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> upperNums = new List<int>();
            List<int> lowerNums = new List<int>();

            for(int i = 0; i < nums.Count; ++i)
            {
                if(i > nums.Count / 2 - 1)
                {
                    int firstDigit = nums[i] / 10;
                    int secondDigit = nums[i] % 10;

                    upperNums.Add(firstDigit);
                    upperNums.Add(secondDigit);
                }
                else
                {
                    lowerNums.Add(nums[i]);
                }
            }
            nums.Clear();
            
            for(int i = 0, j = 0; i < lowerNums.Count; ++i)
            {
                nums.Add(upperNums[j++]);
                nums.Add(lowerNums[i]);
                nums.Add(upperNums[j++]);
            }
            Console.WriteLine(String.Join(" ", nums));
            int t = 0;

        }
    }
}
