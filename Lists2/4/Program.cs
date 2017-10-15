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
            
            char[] delimiters = ",;:.!()\"'\\/[] ".ToCharArray();
            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> upper = new List<string>();
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
           
            for (int i = 0; i < words.Length; ++i)
            {
                bool isUpper = true;
                bool isLower = true;
                foreach (char ch in words[i])
                {
                    if (char.IsUpper(ch))
                    {
                        isLower = false;
                    }
                    else if (char.IsLower(ch))
                    {
                        isUpper = false;
                    }
                    else if (!char.IsLetter(ch))
                    {
                        isUpper = false;
                        isLower = false;
                    }
                }
                if(isLower)
                {
                    lower.Add(words[i]);
                }
                else if (isUpper)
                {
                    upper.Add(words[i]);
                }
                else
                {
                    mixed.Add(words[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }
    }
}
