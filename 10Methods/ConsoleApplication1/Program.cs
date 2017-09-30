using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if(a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMax(char ch1, char ch2)
        {
            int i1 = (int)ch1;
            int i2 = (int)ch2;
            int max = GetMax(i1, i2);
            return (char)max;
        }
        static string GetMax(string str1, string str2)
        {
            if(str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
        
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstVar = Console.ReadLine();
            string secondVar = Console.ReadLine();
            string result = "";
            switch (type)
            {
                case "int":
                    int a = int.Parse(firstVar);
                    int b = int.Parse(secondVar);
                    int max = GetMax(a, b);
                    result = max.ToString();
                    break;
                case "char":
                    char ch1 = char.Parse(firstVar);
                    char ch2 = char.Parse(secondVar);
                    char maxChar = GetMax(ch1, ch2);
                    result = maxChar.ToString();
                    break;
                case "string":
                    result = GetMax(firstVar, secondVar);
                    break;
                default:
                    break;

            }
            Console.WriteLine(result);
        }
    }
}
