using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace temp1
{
    class Herro
    {
        public string Name { get; set; }
                     
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = "abnie";
            string line2 = "anie";
            Console.WriteLine(line1.CompareTo(line2));
        }
    }
}
