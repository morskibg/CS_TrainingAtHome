using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for(int i = 0; i < nums.Length; ++i)
            {
                if(nums[i] >= 0)
                {
                    Console.WriteLine($"{nums[i]} => {Math.Round(nums[i],0, MidpointRounding.AwayFromZero)}");
                }
                else
                {
                    Console.WriteLine($"{nums[i]} => {Math.Round(nums[i] ,0, MidpointRounding.AwayFromZero)}");
                }
            }
        }
    }
}
