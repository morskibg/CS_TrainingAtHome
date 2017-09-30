using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n6
{
    
    class Program
    {
        static int HowManyDigits(int num)
        {
            int counter = 0;
            while(num != 0)
            {
                num /= 10;
                ++counter;
            }
            return counter;
        }
        static List<int> RemoveBiggerNums(List<int> nums)
        {
            int minDigits = 0;
            foreach(int i in nums)
            {
                int currDigits = HowManyDigits(i);
                if(currDigits < minDigits || minDigits == 0)
                {
                    minDigits = currDigits;
                }
            }
            List<int> cleanedNums = new List<int>();
            foreach (int i in nums)
            {
                int curDigits = HowManyDigits(i);
                if (curDigits == minDigits)
                {
                    cleanedNums.Add(i);
                }
            }
            return cleanedNums;
        }
        static void Main(string[] args)
        {
            List<int> firstZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondZip = Console.ReadLine().Split(' ').Select(int.Parse).ToList();           
            List<int> zippedList = new List<int>();

            firstZip = RemoveBiggerNums(firstZip);
            secondZip = RemoveBiggerNums(secondZip);

            int biggerSize = firstZip.Count >= secondZip.Count ? firstZip.Count : secondZip.Count;
            for(int i = 0; i < biggerSize; ++i)
            {
                if(secondZip.Count > i)
                {
                    zippedList.Add(secondZip[i]);
                }
                if(firstZip.Count > i)
                {
                    zippedList.Add(firstZip[i]);
                }
            }
            zippedList = RemoveBiggerNums(zippedList);
            Console.WriteLine(String.Join(" ", zippedList));
            int t = 0;



        }
    }
}
