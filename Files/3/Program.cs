using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mergedList = new List<string>();
            string[] f1 = File.ReadAllLines("f1.txt");
            string[] f2 = File.ReadAllLines("f2.txt");
            for (int i = 0; i < f1.Length; i++)
            {
                mergedList.Add(f1[i]);
                mergedList.Add(f2[i]);
            }
            File.WriteAllLines("merged.txt", mergedList);
        }
    }
}
