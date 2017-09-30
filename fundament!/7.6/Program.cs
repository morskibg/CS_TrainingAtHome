using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6
{
    class Program
    {
        static int findDigit(char ch)
        {
            switch (ch)
            {
                case 'A':
                    return 1;
                case 'C':
                    return 2;
                case 'G':
                    return 3;
                case 'T':
                    return 4;
                default:
                    return 0;
            }
        }
        static int calcSum(char first, char second, char third)
        {
            int sum = findDigit(first);
            sum += findDigit(second);
            sum += findDigit(third);
            return sum;
        }
        static void Main(string[] args)
        {
            int printLineCount = 4;
            int inputSum = int.Parse(Console.ReadLine());
            List<char> nucleotides = new List<char>()
            {
                {'A'}, {'C'}, {'G'}, {'T'}
            };
            string nucleoCombination = "";
            for (int i = 0; i < nucleotides.Count(); ++i)
            {
                for (int j = 0; j < nucleotides.Count(); ++j)
                {
                    for (int k = 0; k < nucleotides.Count(); ++k)
                    {
                        string addition = "X";
                        int currentSum = calcSum(nucleotides[i], nucleotides[j], nucleotides[k]);
                        if (currentSum >= inputSum)
                        {
                            addition = "O";
                        }
                        nucleoCombination = addition + nucleotides[i].ToString() + nucleotides[j].ToString() + nucleotides[k].ToString() + addition;
                        Console.Write(nucleoCombination + " ");
                        --printLineCount;
                        if(printLineCount == 0)
                        {
                            Console.WriteLine();
                            printLineCount = 4;
                        }
                    }
                }
            }
        }
    }
}
