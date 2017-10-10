using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double average = nums.Average();
            string command = Console.ReadLine();
            if(command == "All")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x >= average).OrderBy(x => x)));
            }
            else if(command == "Min")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x >= average).OrderBy(x => x).Take(1)));
            }
            else if (command == "Max")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x >= average).OrderByDescending(x => x).Take(1)));
            }
        }
    }
}
