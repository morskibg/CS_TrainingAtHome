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
            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            
            bool isFinished = false;
            while (!isFinished)
            {
                isFinished = true;
                for (int i = 0; i < nums.Count - 1; ++i)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        isFinished = false;
                        double newNum = nums[i] + nums[i + 1];
                        nums.RemoveRange(i, 2);
                        nums.Insert(i, newNum);
                        //++i;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
