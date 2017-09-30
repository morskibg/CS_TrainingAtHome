using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            int sum = 0;
            for(int i = 0; i < size; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
