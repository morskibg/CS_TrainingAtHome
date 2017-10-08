using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = ".,:;()[]\"\';\\/!? ".ToCharArray();
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(z => z)
                .ToArray();
            Console.WriteLine(string.Join(", ", words));
            
        }
    }
}
