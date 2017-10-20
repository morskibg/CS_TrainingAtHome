using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyWords = File.ReadAllText("words.txt")
                .ToLower().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            string[] text = File.ReadAllText("Input.txt").ToLower().Split(new char[] { ' ', ',', '.', ':', '\t','-','?','\\','\n','\r','!' }, StringSplitOptions.RemoveEmptyEntries)
                
                .ToArray(); ;
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in text.Where(x => keyWords.Contains(x)))
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }
                wordsCount[word]++;
            }
            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("oyt2.txt", (word.Key.ToString() + " " + "-" + " " + word.Value.ToString() + Environment.NewLine));
            }
        }
    }
}