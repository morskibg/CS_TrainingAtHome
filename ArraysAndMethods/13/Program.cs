using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            bool isIncreasing = true;
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            int size = words.Count();
            int[] nums = new int[size];

            int firstNum = int.Parse(words[0]);
            for (int i = 1; i < size; ++i)
            {
                nums[i] = int.Parse(words[i]);
                if(nums[i] != firstNum)               
                {
                    isIncreasing = false;
                    break;
                }
                
            }
            Console.WriteLine("{0}", isIncreasing ? "Yes" : "No" );
        }
    }
}

