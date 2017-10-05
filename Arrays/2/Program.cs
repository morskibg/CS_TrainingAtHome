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
            int inputCounter = int.Parse(Console.ReadLine());
            int[] nums = new int[inputCounter];
            for (int i = 0; i < inputCounter; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(nums);
            Console.WriteLine($"{string.Join(" ", nums)}");
        }
    }
}
