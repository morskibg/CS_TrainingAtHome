using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayEarning
{
    class Program
    {
        const double bonus = 2.5;
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dayEarning = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            double monthPayCheck = workingDays * dayEarning;
            double YearPayCheck = 12 * monthPayCheck + bonus * monthPayCheck;
            YearPayCheck -= YearPayCheck * 0.25;
            double levaPerDay = (YearPayCheck * rate) / 365;
            Console.WriteLine(levaPerDay.ToString("0.00"));
            
        }
    }
}
