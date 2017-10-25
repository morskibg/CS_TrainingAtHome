using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool MelrahShake(ref StringBuilder text, ref StringBuilder pattern)
        {
            string tempText = text.ToString();
            string tempPattern = pattern.ToString();
            if (!tempText.Contains(tempPattern))
            {
                return false;
            }
            int beginIdx = tempText.IndexOf(tempPattern);
            int endIdx = tempText.LastIndexOf(tempPattern);
            text.Remove(beginIdx, pattern.Length);
            if (beginIdx == endIdx)
            {
                pattern.Remove(pattern.Length / 2, 1);
                return false;
            }
            endIdx -= pattern.Length; 
            text.Remove(endIdx, text.Length - endIdx - pattern.Length);
            pattern.Remove(pattern.Length / 2, 1);
            if(pattern.Length == 0)
            {
                return false;
            }
            int t = 0;
            return true;
        }
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            StringBuilder pattern = new StringBuilder(Console.ReadLine());
            bool isCompleted = false;
            while (!isCompleted)
            {
                isCompleted =  MelrahShake(ref text, ref pattern);
            }
        }
    }
}
