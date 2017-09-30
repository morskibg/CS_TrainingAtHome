using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static string Encrypt(char letter)
        {
            string firstLetter = GetFirstLetter(letter);
            string lastLetter = GetLastLetter(letter);
            int asciiCode = (int)letter;
            string prefix = ((char)(asciiCode + (asciiCode % 10))).ToString();
            int firstDigit = int.Parse(firstLetter);
            string suffix = ((char)(asciiCode - firstDigit)).ToString();
            string result = prefix + firstLetter + lastLetter + suffix;
            return result;
        }
        static string GetFirstLetter(char letter)
        {
            int asciiNumber = (int)letter;
            string result = "";
            while(asciiNumber != 0)
            {
                result = (asciiNumber % 10).ToString();
                asciiNumber /= 10;
            }
            return result;
        }
        static string GetLastLetter(char letter)
        {
            return ((int)letter % 10).ToString();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string encrypted = "";
            while(n > 0)
            {
                --n;
                char currChar = char.Parse(Console.ReadLine());
                encrypted += Encrypt(currChar);                
            }
            Console.WriteLine(encrypted);
        }
    }
}
