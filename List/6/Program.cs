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
            List<int> myList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            myList.Sort();
            int listIndex = 0;
            while (true)
            {
                int currNum = myList[listIndex];
                int lastIndexOfCurrentNum = myList.LastIndexOf(currNum);
                Console.WriteLine("{0} -> {1}", currNum, lastIndexOfCurrentNum - listIndex + 1);
                listIndex = lastIndexOfCurrentNum + 1;
                
                if(listIndex == myList.Count)
                {
                    break;
                }
            }
        }
    }
}
