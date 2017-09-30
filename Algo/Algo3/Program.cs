using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nums = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();
            while (command != "Print")
            {
                int breakPoint = int.Parse(command);
                int leftArrSize = breakPoint;
                int rightArrSize = nums.Length - breakPoint - 1;
                for (int i = 0; i < leftArrSize / 2; ++i)
                {
                    int secondIndex = leftArrSize - 1 - i;
                    string temp = nums[secondIndex];
                    nums[secondIndex] = nums[i];
                    nums[i] = temp;
                }
                int begin = breakPoint + 1;
                int end = begin + rightArrSize / 2;
                for (int i = begin, j = nums.Length - 1; i < end; ++i, --j)
                {
                    
                    string temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
