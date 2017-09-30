using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL4
{
    class Program
    {
        static int compareValues(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            return b.Value.CompareTo(a.Value);
        }
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ').ToArray();
            int inputWordsCount = inputWords.Length;
            List<KeyValuePair<string, int>> wordsAndCounts = new List<KeyValuePair<string, int>>();
            foreach(string word in inputWords)
            {
                if(wordsAndCounts.Exists(kvp => kvp.Key == word))
                {
                    int currCount = wordsAndCounts.FirstOrDefault(kvp => kvp.Key == word).Value;
                    wordsAndCounts.Remove(wordsAndCounts.FirstOrDefault(kvp => kvp.Key == word));
                    KeyValuePair<string, int> newCounterPair = new KeyValuePair<string, int>(word, currCount + 1);
                    wordsAndCounts.Add(newCounterPair);
                }
                else
                {
                    KeyValuePair<string, int> newPair = new KeyValuePair<string, int>(word, 1);
                    wordsAndCounts.Add(newPair);

                }
            }
            var sortedWordsByCounts = wordsAndCounts.OrderByDescending(kvp => kvp.Value);
            //wordsAndCounts.Sort(compareValues);            
            foreach (var pair in sortedWordsByCounts)
            {
                double percentage = (double)pair.Value / inputWordsCount * 100;
                Console.WriteLine($"{pair.Key} -> {pair.Value} times ({percentage:F2}%)");
            }

        }
    }
}
