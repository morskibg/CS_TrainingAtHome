using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{   
    class Program
    {
        static int[] ResizeAddCompleteArray(int[] arr, int newSize)
        {
            int[] newArr = new int[newSize];
            int j = 0;
            for(int i = 0; i < newSize; ++i)
            {
                if(j == arr.Length )
                {
                    j = 0;
                }
                newArr[i] = arr[j++];
            }
            return newArr;
        }
        static void MergeTwoArray(ref int[] arr1, ref int[] arr2)
        {
            for(int i = 0; i < arr1.Length; ++i)
            {
                arr1[i] += arr2[i];
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int biggerSize = arr1.Length;
            if(arr1.Length >= arr2.Length)
            {
                arr2 = ResizeAddCompleteArray(arr2, biggerSize);
            }
            else
            {
                biggerSize = arr2.Length;
                arr1 = ResizeAddCompleteArray(arr1, biggerSize);
            }
            MergeTwoArray(ref arr1, ref arr2);
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
