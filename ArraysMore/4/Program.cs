using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static string GetPhonebookData(string inputData, string[] phoneNumbers, string[] names)
        {
            if (char.IsLetter(inputData.First()))
            {// is name
                for (int i = 0; i < names.Length; ++i)
                {
                    if (inputData == names[i])
                    {
                        return phoneNumbers[i];
                    }
                }
                return "none";
            }
            else
            {// is number
                for(int i = 0; i < phoneNumbers.Length; ++i)
                {
                    if(inputData == phoneNumbers[i])
                    {
                        return names[i];
                    }
                }
                return "none";
            }           
        }
        static long GetSumOfDigits(string stringNum)
        {
            long sum = 0;
            string normalizedNumber = parsePhoneNumber(stringNum);
            long num = long.Parse(normalizedNumber);
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static long GetDiffOfDigits(string stringNum)
        {
            long diff = 0;
            string normalizedNumber = parsePhoneNumber(stringNum);
                       
            long num = long.Parse(normalizedNumber);
            long startNum = num;
            while (num != 0)
            {
                if(num == startNum)
                {
                    diff = num % 10;
                }
                else
                {
                    diff -= num % 10;                    
                }
                num /= 10;

            }
            return diff;
        }
        static string parsePhoneNumber(string inputString)
        {
            string result = "";
            foreach(char ch in inputString)
            {
                if (char.IsDigit(ch))
                {
                    result += ch.ToString();
                }
            }
            return result;
        }
        
        static void Main(string[] args)
        {
           
            string[] phoneNumbers = Console.ReadLine().Split(' ');           
            string[] names = Console.ReadLine().Split(' ');
            string inputLine = Console.ReadLine();
           
            while (inputLine != "done")
            {
                string[] currCommand = inputLine.Split(' ');
                if(currCommand.First() == "call")
                {
                    string calleeData = GetPhonebookData(currCommand.Last(), phoneNumbers, names);
                    Console.WriteLine("calling {0}...", calleeData);
                    long sumOfDigits = 0;
                    if (char.IsLetter(currCommand.Last()[0]))
                    {
                        sumOfDigits = GetSumOfDigits(calleeData);
                    }
                    else
                    {
                        sumOfDigits = GetSumOfDigits(currCommand.Last());
                    }
                    if(sumOfDigits % 2 == 0)
                    {
                        int hours = (int)sumOfDigits / 60;
                        string hoursString = hours.ToString();
                        if(hours < 10)
                        {
                            hoursString = "0" + hours.ToString();
                        }
                        int minutes = (int)sumOfDigits - hours * 60;
                        string minutesString = minutes.ToString();
                        if(minutes < 10)
                        {
                            minutesString = "0" + minutes.ToString();
                        }
                        string callDuration = hoursString + ":" + minutesString;
                        Console.WriteLine("call ended. duration: {0}", callDuration);
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }                        
                }
                else if(currCommand.First() == "message")
                {
                    string calleeData = GetPhonebookData(currCommand.Last(), phoneNumbers, names);
                    Console.WriteLine("sending sms to {0}...", calleeData);
                    long diffOfDigits = 0;
                    if (char.IsLetter(currCommand.Last()[0]))
                    {
                        diffOfDigits = GetDiffOfDigits(calleeData);
                    }
                    else
                    {
                        diffOfDigits = GetDiffOfDigits(currCommand.Last());
                    }
                    if (diffOfDigits % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
