using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(x => x == (int)Math.Sqrt((double)x) * (int)Math.Sqrt((double)x))
                .OrderByDescending(x => x)
                .ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
