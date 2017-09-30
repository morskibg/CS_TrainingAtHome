using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL41
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ').ToArray();
            int inputWordsCount = inputWords.Length;
            Dictionary<string, int> wordsAndCounts = new Dictionary<string, int>();
            foreach(string word in inputWords)
            {
                if (wordsAndCounts.ContainsKey(word))
                {
                    wordsAndCounts[word]++;
                }
                else
                {
                    wordsAndCounts.Add(word, 1);
                }
            }
            var Sorted = wordsAndCounts.OrderByDescending(x => x.Value);
            foreach (var item in Sorted)
            {
                double percentage = (double)item.Value / inputWordsCount * 100;
                Console.WriteLine($"{item.Key} -> {item.Value} times ({percentage:F2}%)");
            }
        }
    }
}
