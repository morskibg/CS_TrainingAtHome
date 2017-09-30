using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6v2
{
    class Program
    {
        static void Main(string[] args)
        {
           int inputNum = int.Parse(Console.ReadLine());
            List<KeyValuePair<char, int>> basicNucleo = new List<KeyValuePair<char, int>>()
            {
                new KeyValuePair<char, int>('A', 1),  new KeyValuePair<char, int>('C', 2),
                new KeyValuePair<char, int>('G', 3),  new KeyValuePair<char, int>('T', 4)
            };
            string nucleoCombination = "";
            int printCount = 4;
            for(int i = 0; i < basicNucleo.Count(); ++i)
            {
                for(int j = 0; j < basicNucleo.Count(); ++j)
                {
                    for(int k = 0; k < basicNucleo.Count(); ++k)
                    {
                        string addition = "X";
                        int currSum = basicNucleo[i].Value + basicNucleo[j].Value + basicNucleo[k].Value;
                        if(currSum >= inputNum)
                        {
                            addition = "O";
                        }
                        nucleoCombination = addition + basicNucleo[i].Key.ToString() + basicNucleo[j].Key.ToString() + basicNucleo[k].Key.ToString() + addition;
                        Console.Write(nucleoCombination + " ");
                        --printCount;
                        if(printCount == 0)
                        {
                            Console.WriteLine();
                            printCount = 4;
                        }

                    }
                }
            }
        }
    }
}
