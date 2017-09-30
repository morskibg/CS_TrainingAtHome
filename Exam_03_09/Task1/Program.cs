using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        const double BGN_to_USD = 1.85;
        const double priceUSDCoverPerM2 = 7;
        const double priceUSDCarePerM2 = 9;
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());
            double totalCoverArea = tables * (tableLength + 2 * 0.3) * (tableWidth + 2 * 0.3);
            double totalCareArea = tables * (tableLength / 2) * (tableLength / 2);
            double totalaCoverPriceUSD = totalCoverArea * priceUSDCoverPerM2;
            double totalCarePriceUSD = totalCareArea * priceUSDCarePerM2;
            Console.WriteLine("{0:f2} USD", totalaCoverPriceUSD + totalCarePriceUSD);
            Console.WriteLine("{0:f2} BGN", (totalaCoverPriceUSD + totalCarePriceUSD) * BGN_to_USD);

        }
    }
}
