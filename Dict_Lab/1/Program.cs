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
            String[] words = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToArray();
           
            Dictionary<string, int> wordcount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                
                if (wordcount.ContainsKey(word))
                {
                    wordcount[word]++;
                }
                else
                {
                    wordcount[word] = 1;
                }
            }
            wordcount = wordcount.Where(kvp => kvp.Value % 2 != 0).ToDictionary(key => key.Key, value => value.Value);
            Console.WriteLine(string.Join(", ", wordcount.Keys));
        }
    }
}
