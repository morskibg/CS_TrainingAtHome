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
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size = arr1.Length;
            int startIdx = size / 2 - 1;
            int endIdx = 0;
            if(size == 1)
            {
                Console.WriteLine($"{{ {arr1[0]} }}");
            }
            else if(size % 2 == 0)
            {
                //endIdx = startIdx + 1;
                Console.WriteLine($"{{ {arr1[startIdx]}, {arr1[startIdx + 1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {arr1[startIdx]}, {arr1[startIdx + 1]}, {arr1[startIdx + 2]} }}");
            }
        }
    }
}
