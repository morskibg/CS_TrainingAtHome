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
            List<string> blacklistedWords = Console.ReadLine().Split(' ').ToList();
            List<string> redacted = new List<string>();
            //List<string> delimiters = new List<string>() { " ", "-", "#", "$", "%", "&", "\'", "(", ")",
            //        "*", "+", ",", ".", "/", ":", ";", "<", "=" , ">" ,"?",
            //        "@", "[", "\\", "]", "^", "`", "{", "|", "}", "~", "_"};
            
            string line = Console.ReadLine();
            //int size = blacklistedWords.Count;
            //for (int i = 0; i < size; ++i)
            //{
            //    if (delimiters.Contains(blacklistedWords[i]))
            //    {
            //        delimiters.Remove(blacklistedWords[i]);

            //    }
            //}
           // char[] delimiter = { ' ', '.', '-' }; 
           
            while (line != "end")
            {
                //List<string> currWords = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
                bool isPresent = false;
                for(int i = 0; i < blacklistedWords.Count; ++i)
                {
                    if (line.Contains(blacklistedWords[i]))
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (!isPresent)
                {
                    redacted.Add(line);
                }
                line = Console.ReadLine();
            }
            redacted.Sort();
            Console.Write(String.Join("\n", redacted));
            
        }
    }
}
