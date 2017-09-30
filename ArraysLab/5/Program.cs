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
            string line = Console.ReadLine();
            char delimiter = ' ';
            string[] words = line.Split(delimiter);
            int size = words.Count();
            int[] nums = new int[size];
            
            for (int i = 0; i < size; ++i)
            {
                nums[i] = int.Parse(words[i]);
                if(nums[i] % 2 == 0)
                {
                    continue;
                }
                else if(i % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, nums[i]);

                }
            }
            
        }
    }
}
