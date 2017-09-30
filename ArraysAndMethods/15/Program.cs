using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            int upperCpiunter = 0;
            foreach(string currSubString in words)
            {
                if (char.IsUpper(currSubString[0]) && currSubString.Count() == 1)
                {
                    ++upperCpiunter;
                }
            }
            Console.WriteLine(upperCpiunter);
        }
    }
}
