using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            int i = 0;
            List<string> modTextLines = lines.Select(x => (++i).ToString() + "." + " " +  x).ToList();
            File.WriteAllLines("outFile3.txt", modTextLines);
           
        }
    }
}
