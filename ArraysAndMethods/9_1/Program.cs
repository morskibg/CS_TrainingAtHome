using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int negativeNumsCounter = 0;
            for (int i = 0; i < n; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] < 0)
                {
                    ++negativeNumsCounter;
                }
            }
            Console.WriteLine(negativeNumsCounter);
        }
    }
}
