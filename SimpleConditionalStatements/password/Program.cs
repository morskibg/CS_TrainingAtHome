using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        const string password = "s3cr3t!P@ssw0rd";
        static void Main(string[] args)
        {
            var inputNum = double.Parse(Console.ReadLine());
            if (inputNum > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (inputNum > 150)
            {
                Console.WriteLine("ultra fast");
            }
            else if (inputNum > 50)
            {
                Console.WriteLine("fast");
            }
            else if (inputNum > 10)
            {
                Console.WriteLine("average");
            }
            else
            {
                Console.WriteLine("slow");
            }

        }
    }
}
