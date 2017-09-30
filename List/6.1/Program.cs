using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int[] countArray = new int[myList.Max() + 1];
            foreach(int currNum in myList)
            {
                countArray[currNum]++;
            }
            for(int i = 0; i < countArray.Length;++i)
            {
                if (countArray[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, countArray[i]);
                }
            }
        }
    }
}
