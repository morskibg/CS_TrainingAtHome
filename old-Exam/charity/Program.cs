using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charity
{
    class Program
    {
        const double cakePrice = 45.0;
        const double mufflesPrice = 5.8;
        const double pancakesPrice = 3.2;
        const double expenses = 1 / 8.0;
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int muffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double dayMoney = cakes * cakePrice + muffles * mufflesPrice + pancakes * pancakesPrice;
            dayMoney -= dayMoney * expenses;
            double totalMoney = dayMoney * chefs * days;
            Console.WriteLine("{0:F2}", totalMoney);
        }
    }
}
