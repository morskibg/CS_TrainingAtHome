using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
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
            for(int i = 0; i < size; ++i)
            {
                nums[i] = int.Parse(words[i]);
            }
            int min = nums.Min();
            Console.WriteLine(min);
        }
    }
}
