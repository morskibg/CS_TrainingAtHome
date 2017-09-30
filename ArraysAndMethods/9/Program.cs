using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for(int i = 0; i < n; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int counter = 1;
            int largest = nums[0];
            for(int i = 0; i < n; ++i)
            {
                int currNum = nums[i];                
                for(int j = i + 1; j < n; ++j)
                {
                    int currCounter = 1;
                    if(currNum == nums[j])
                    {
                        ++currCounter;
                        if(currCounter > counter)
                        {
                            largest = currNum;
                            counter = currCounter;
                        }
                        
                    }
                }
            }
            Console.WriteLine(largest);
        }
    }
}
