using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convertor
{
    class Program
    {
        enum Currencies { BGN, USD, EUR, GBR };
        const double USD_rate = 1.79549;
        const double EUR_rate = 1.95583;
        const double GBP_rate = 2.53405;
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double current_from_rate = 0;
            double current_to_rate = 0;
            if(from == "BGN")
            {
                current_from_rate = 1.0;
            }
            else if(from == "USD")
            {
                current_from_rate = USD_rate;
            }
            else if (from == "EUR")
            {
                current_from_rate = EUR_rate;
            }
            else if (from == "GBP")
            {
                current_from_rate = GBP_rate;
            }

            if(to == "USD")
            {
                current_to_rate = USD_rate;
            }
            else if(to == "BGN")
            {
                current_to_rate = 1.0;
            }
            else if(to == "EUR")
            {
                current_to_rate = EUR_rate;
            }
            else if(to == "GBP")
            {
                current_to_rate = GBP_rate;
            }
            double result = Math.Round((amount * current_from_rate / current_to_rate), 2);
            Console.WriteLine("{0} {1}", result, to);

        }
    }
}
