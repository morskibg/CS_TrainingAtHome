using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> emplAge = new Dictionary<string, int>();
            Dictionary<string, double> empSalary = new Dictionary<string, double>();
            Dictionary<string, string> empPosition = new Dictionary<string, string>();
            while (input != "filter base")
            {
                
                char[] delimiters = " ->".ToCharArray();
                string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                string empName = words.First();
                string empData = words.Last();
                int age = 0;
                double salary = 0;

                if (int.TryParse(empData, out age))
                {
                    emplAge[empName] = int.Parse(empData);
                }
                else if (double.TryParse(empData, out salary))
                {
                    empSalary[empName] = double.Parse(empData);
                }
                else
                {
                    empPosition[empName] = empData;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            if (input == "Position")
            {
                foreach (var position in empPosition)
                {
                    Console.WriteLine($"Name: {position.Key}");
                    Console.WriteLine($"Position: {position.Value}");
                    Console.WriteLine("{0}", new string('=', 20));
                }
            }
            else if (input == "Age")
            {
                foreach (var age in emplAge)
                {
                    Console.WriteLine($"Name: {age.Key}");
                    Console.WriteLine($"Age: {age.Value}");
                    Console.WriteLine("{0}", new string('=', 20));
                }
            }
            else
            {
                foreach (var salary in empSalary)
                {
                    Console.WriteLine($"Name: {salary.Key}");
                    Console.WriteLine($"Salary: {salary.Value:f2}");
                    Console.WriteLine("{0}", new string('=', 20));
                }
            }
        }
    }
}
