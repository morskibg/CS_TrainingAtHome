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
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toSkip = commands[0];
            int toTake = commands[1];
            int[] processedNums = nums                          
                .Where(x => x >= 65)
                .Where(x => x <= 90)                
                .Skip(toSkip)
                .Take(toTake)
                .ToArray();
            string result = "";
            foreach(int num in processedNums)
            {
                result += (char)num;
            }
            Console.WriteLine(result);

        }
    }
}
