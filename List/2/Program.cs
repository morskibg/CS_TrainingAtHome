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
            string[] delim = new string[] { "|"} ;
            var myList = Console.ReadLine().Split(delim ,StringSplitOptions.RemoveEmptyEntries).ToList();
            delim[0] = " " ;
            for(int i = myList.Count - 1; i >= 0; --i)
            {
                var currList = myList[i].Split(delim, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach(string s in currList)
                {
                    Console.Write(s + " ");
                }
            }
            int t = 0;

        }
    }
}
