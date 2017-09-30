using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> uniqueNums = new List<int>();
            foreach(int num in nums)
            {
                if (!uniqueNums.Contains(num))
                {
                    uniqueNums.Add(num);
                }
            }
            Console.WriteLine(String.Join(" ", uniqueNums));
        }
    }
}
