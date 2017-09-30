using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2
{
    class Program
    {
        static int LinearSearch(int[] nums, int item)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                ++counter;
                if (nums[i] == item)
                {
                    return counter;
                }
            }
            return -counter;
        }

        static int BinarySearch(int[] nums, int item)
        {
            int counter = 0;
            Array.Sort(nums);
            int begin = 0;
            int end = nums.Length - 1;
            while (end >= begin)
            {
                ++counter;
                int midPoint = begin + (end - begin) / 2;
                if (item == nums[midPoint])
                {
                    return counter;
                }
                else if (nums[midPoint] > item)
                {
                    end = midPoint - 1;
                }
                else
                {
                    begin = midPoint + 1;
                }
            }
            return -counter;
        }
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int item = int.Parse(Console.ReadLine());
            int linearCounter = LinearSearch(nums, item);
            int binaryCounter = BinarySearch(nums, item);
            Console.WriteLine("{0}", linearCounter > 0 ? "Yes" : "No");
            Console.WriteLine($"Linear search made {Math.Abs(linearCounter)} iterations");
            Console.WriteLine($"Binary search made {Math.Abs(binaryCounter)} iterations");
        }
    }
}
