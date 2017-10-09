using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delim = "|".ToCharArray();
            string[] parts = Console.ReadLine().Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<int> nums = new List<int>();
            for (int i = parts.Length - 1; i >= 0; --i)
            {
                List<int> tempList = parts[i]
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                
                foreach (int num in tempList)
                {
                    nums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
