using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            bool isSymmetric = true;
            int size = words.Count();
            int j = 1;
            for(int i = 0; i < size / 2; ++i, ++j)
            {
                if(words[i] != words[size - j])
                {
                    isSymmetric = false;
                    break;
                }
            }
            Console.WriteLine("{0}", isSymmetric ? "Yes" : "No");
        }
    }
}
