using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Time for Code"))
                {
                    break;
                }
                string ID = Regex.Match(input, @"^(.+?)").Value.Trim();
                string eventName = Regex.Match(input, @"(?<=\#)(.+?(?=\s))").Value.Trim();
                var participants = Regex.Matches(input, @"(?<=\@).+?(?=\s|$)").Cast<Match>().Select(x => x.Value.Trim())

                    .ToList();

                int t = 0;

            }
           
        }
    }
}
