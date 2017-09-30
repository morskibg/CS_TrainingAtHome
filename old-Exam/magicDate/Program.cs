using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());
            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);
            DateTime currDate = startDate;
            bool isFounded = false;
            while(currDate.Date != endDate.AddDays(1).Date)
            {
                string wholeDateString = currDate.Date.Day.ToString() + currDate.Date.Month.ToString() + currDate.Date.Year.ToString();
                int wholeDateNum = int.Parse(wholeDateString);
                int temp = wholeDateNum;
                List<int> digits = new List<int>();
                int currWeigth = 0;
                while(temp > 0)
                {
                    int digit = temp % 10;
                    digits.Add(digit);
                    temp /= 10;
                    if(temp == 0)
                    {
                        break;
                    }                    
                }
                while (digits.Count > 0)
                {
                    for (int i = 0; i < digits.Count - 1; ++i)
                    {
                        currWeigth += digits[digits.Count - 1] * digits[i];
                    }
                    digits.RemoveAt(digits.Count - 1);
                }
                if(currWeigth == magicWeight)
                {
                    isFounded = true;
                    int day = currDate.Date.Day;
                    string dayString = "0";
                    if(day < 10)
                    {
                        dayString += day.ToString();
                    }
                    else
                    {
                        dayString = day.ToString();
                    }
                    int month = currDate.Date.Month;
                    string monthString = "0";
                    if(month < 10)
                    {
                        monthString += month.ToString();
                    }
                    else
                    {
                        monthString = month.ToString();
                    }
                    Console.Write("{0}-{1}-{2}", dayString, monthString, currDate.Date.Year);
                    Console.WriteLine();
                    
                }
                currDate = currDate.AddDays(1);
               
            }
            if (!isFounded)
            {
                Console.WriteLine("No");
            }
        }
    }
}
