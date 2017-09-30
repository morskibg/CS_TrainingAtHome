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
            string[] words = Console.ReadLine().Split(' ');
            for(int i = 0; i < words.Length; ++i)
            {
                int currNum = int.Parse(words[i]);
                if(currNum == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
