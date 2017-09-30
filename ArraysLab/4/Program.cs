using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            int size = words.Count();
            Console.Write(words[size - 1] + " ");
            for(int i = 0; i < size - 1; ++i)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
