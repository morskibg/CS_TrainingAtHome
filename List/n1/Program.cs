using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(' ').ToList();
            for(int i = 0; i < myList.Count; ++i)
            {
                if(i % 2 != 0 && i != 0)
                {
                    Console.Write(myList[i]);
                }
            }
           
        }
    }
}
