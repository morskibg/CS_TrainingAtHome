using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while(arr1.Length > 1)
            {
                int[] smallerArr = new int[arr1.Length - 1];
                for(int i = 0; i < smallerArr.Length; ++i)
                {
                    smallerArr[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = smallerArr;
            }
            Console.WriteLine(arr1[0]);
        }
    }
}
