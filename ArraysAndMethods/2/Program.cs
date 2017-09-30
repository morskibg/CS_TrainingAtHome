using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static int GetMin(int a, int b)
        {
            return (a <= b) ? a : b;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            for(int i = 0; i < 3; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int min1 = GetMin(nums[0], nums[1]);
            int min2 = GetMin(min1, nums[2]);
            Console.WriteLine(GetMin(min1, min2));            
        }
    }
}
