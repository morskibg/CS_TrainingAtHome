using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algo6
{
    class Program
    {
        static List<int> ExtractDigits(int inputNum)
        {
            List<int> digits = new List<int>();
            while (inputNum != 0)
            {
                digits.Add(inputNum % 10);
                inputNum /= 10;
            }
            digits.Reverse();
            return digits;
        }
        static int ReareangeSequence(ref List<int> digitsList, string command, int number)
        {
            int extremalNum = command == "Max" ? int.MinValue : int.MaxValue;
            int counter = 0;
            while (counter < digitsList.Count)
            {
                ++counter;
                int currentNumber = int.Parse(string.Join("", digitsList));
                if (command == "Max")
                {
                    if (extremalNum < currentNumber)
                    {
                        extremalNum = currentNumber;
                    }
                }
                else
                {
                    if (extremalNum > currentNumber)
                    {
                        extremalNum = currentNumber;
                    }
                }
                int carry = digitsList[0];
                digitsList.RemoveAt(0);
                digitsList.Add(carry);
            }
            return extremalNum;
            
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<int> finalList = new List<int>();

            for (int i = 0; i < numbers.Count; ++i)
            {
                List<int> digits = ExtractDigits(numbers[i]);
                int rearangedNum = ReareangeSequence(ref digits, command, numbers[i]);
                finalList.Add(rearangedNum);
            }
            Console.WriteLine(string.Join(", ", finalList));
            Console.WriteLine(finalList.Sum());
        }
    }
}
