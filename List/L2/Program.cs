using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Program
    {
        static int GetIndex(int num)
        {
            int index = 0;
            while(num != 0)
            {
                index = num % 10;
                num /= 10;
            }
            return index;
        }
        static void Main(string[] args)
        {
            
            List<int> bigList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            string line = Console.ReadLine();
            while (line != "end")
            {

                int currNum = int.Parse(line);
                int listIndex = GetIndex(currNum);
                
                bigList.Insert(listIndex, currNum);
                line = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", bigList));
        }
    }
}
