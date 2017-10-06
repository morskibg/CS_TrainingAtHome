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
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string command = Console.ReadLine();
                if (command == "Reverse")
                {
                    Array.Reverse(words);
                }
                else if (command == "Distinct")
                {
                    words = words.Distinct().ToArray();
                }
                else
                {
                    string[] replaceData = command.Split(' ').ToArray();
                    int index = int.Parse(replaceData[1]);
                    words[index] = replaceData[2];
                }
                
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
