using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.CurrentCulture);
            double days = 999;
            DateTime resTime = dt.AddDays(days);            
            Console.WriteLine(resTime.ToString("dd-MM-yyyy"));
        }
    }
}
