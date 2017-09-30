using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        const double rate = 1.79549;
        static void Main(string[] args)
        {
            var dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} BGN", Math.Round((dolar * rate), 2));
        }
    }
}
