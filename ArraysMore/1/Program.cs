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
            // string[] words = Console.ReadLine().Split(' ').ToArray();
            string line = Console.ReadLine();
            string[] words = line.Split(' ');
            Array.Reverse(words);
            string prev = words.First();
            int counter = 1;
            for (int i = 1; i < words.Length; ++i)
            {
                if (prev == words[i])
                {
                    ++counter;
                    if (counter == 3)
                    {
                        if(i == words.Length - 1)
                        {
                            Console.WriteLine(words[i] + " " + words[i] + " " + words[i]);
                            return;
                        }
                        else if(words[i] != words[i + 1])
                        {
                            Console.WriteLine(words[i] + " " + words[i] + " " + words[i]);
                            return;
                        }
                        
                    }
                }
                else
                {
                    counter = 1;
                }
                prev = words[i];
            }


        }
    }
}
