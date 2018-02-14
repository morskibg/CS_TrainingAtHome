using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string p2 = @"\[[^]]*\]*|\{[^}]*\}";
            string p3 = @"[^0-9]*(?<d1>\d{3,})[^0-9]*";
            string pattern = @"(?:(?<bracket>{)|\[)[^0-9]*(?<digits>\d*)[^0-9]*(?(bracket)}|\])";
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
            }

            string line = sb.ToString();

            List<char> words = new List<char>();
            MatchCollection mc = Regex.Matches(line, pattern);

            foreach (Match match in mc)
            {

                Console.WriteLine(match.Groups["digits"]);
                if()


            }
            //MatchCollection mat = Regex.Matches(line, p2);
            //{
            //    foreach (Match match in mat)
            //    {
            //        int cr = match.Groups[0].Length;
            //        MatchCollection innerM = Regex.Matches(match.ToString(), p3);
            //        foreach (Match match1 in innerM)
            //        {

            //            string s = match1.Groups["d1"].ToString();
            //            int size = s.Length;
            //            if (size % 3 != 0)
            //            {
            //                continue;
            //            }
            //            int idx = 0;
            //            while (true)
            //            {
            //                string g = s.Substring(idx, 3);
            //                idx += 3;

            //                int currSize = int.Parse(g);
            //                char currCh = (char)(currSize - cr);
            //                words.Add(currCh);
            //                if (idx == size)
            //                {
            //                    break;
            //                }
            //            }

            //        }
            //    }
            //}

            Console.WriteLine(string.Join("", words));

        }
    }
}
