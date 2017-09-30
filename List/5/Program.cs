using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareList = new List<int>();
            foreach(int num in myList)
            {
                double currRes = Math.Sqrt(num);
                if(currRes == (int)currRes ) 
                {
                    squareList.Add(num);
                }
            }
            squareList.Sort((a, b) => b.CompareTo(a));
            
            Console.WriteLine(String.Join(" ", squareList));
          
        }
    }
}
