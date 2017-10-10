using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            foreach(int n in nums)
            {
                if (!myDict.ContainsKey(n))
                {
                    myDict[n] = 0;
                }
                myDict[n]++;
            }
            foreach(var kvp in myDict.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
