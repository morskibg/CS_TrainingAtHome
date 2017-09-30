using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
           
            bool isContainsDuplicate = true;
            while (isContainsDuplicate)
            {
                isContainsDuplicate = false;
                for (int i = 0; i < myList.Count - 1; ++i)
                {
                    if (myList[i] == myList[i + 1])
                    {
                        myList[i + 1] += myList[i];
                        myList.RemoveAt(i);
                        isContainsDuplicate = true;
                    }
                }
            }
            foreach(double i in myList)
            {
                Console.Write(i + " ");
            }
        }
    }
}
