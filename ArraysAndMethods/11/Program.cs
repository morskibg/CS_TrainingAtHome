using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            double targetNum = double.Parse(Console.ReadLine());
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            int size = words.Count();
            double[] nums = new double[size];
            int biggerThanTargetCounter = 0;
            for(int i = 0; i < size; ++i)
            {
                nums[i] = double.Parse(words[i]);
                if(nums[i] > targetNum)
                {
                    ++biggerThanTargetCounter;
                }
            }
            Console.WriteLine(biggerThanTargetCounter);
        }
    }
}
