using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static string ShowSuccess(string operation, string message)
        {
            string result = "Successfully executed " + operation + ".\n";
            result += new string('=', 30) + "\n";
            result += "Message: " + message + ".";            
            return result;
        }
        static string ShowError(string operation, int code)
        {
            string result = "Error: Failed to execute " + operation + ".\n";
            result += new string('=', 30) + "\n";
            result += "Error Code: " + code.ToString() + ".\n";
            result += "Reason: " + ((code > 0) ? "Invalid Client Data." : "Internal System Failure.");
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                string result = Console.ReadLine();
                if(result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));

                }
                else if(result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
                --n;
            }
        }
    }
}
