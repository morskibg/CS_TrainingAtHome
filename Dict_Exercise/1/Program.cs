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
            char[] inputSymbols = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char ch in inputSymbols)
            {
                if (letters.ContainsKey(ch))
                {
                    letters[ch]++;
                }
                else
                {
                    letters[ch] = 1;
                }
            }
            foreach (var pair in letters)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
