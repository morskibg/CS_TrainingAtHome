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
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] nums = new long[n];
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for(int j = i - 1, m = 0; j >= 0; --j,++m)
                {
                    if(m == k)
                    {
                        break;
                    }
                    sum += nums[j];
                }
                nums[i] = sum;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
