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

            string[] words = Console.ReadLine().Split(new Char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            foreach (string currWord in words)
            {
                bool isUpper = false;
                bool isLower = false;
                
                foreach (char currCh in currWord)
                {
                    if (!char.IsLetter(currCh))
                    {
                        isLower = true;
                        isUpper = true;
                    }

                    else if (char.IsUpper(currCh))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(currCh))
                    {
                        isLower = true;
                    }

                }

                if (isUpper && isLower)
                {
                    mixedCaseWords.Add(currWord);

                }
                else if (isUpper)
                {
                    upperCaseWords.Add(currWord);
                }
                else
                {
                    lowerCaseWords.Add(currWord);
                }             

            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCaseWords));
        }
    }
}