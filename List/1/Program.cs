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
            List<int> myList = new List<int>();
            string[] words = Console.ReadLine().Split(' ');
            foreach(string i in words)
            {
                int currNum = int.Parse(i);
                if( currNum > 0)
                {
                    myList.Add(currNum);
                }                
            }
            if (myList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = myList.Count - 1; i >= 0; --i)
                {
                    Console.Write(myList[i] + " ");
                }
            }
        }
    }
}
