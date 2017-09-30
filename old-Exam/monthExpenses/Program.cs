using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double electro = 0;
            double water = 0;
            double net = 0;
            double other = 0;
            int months = int.Parse(Console.ReadLine());
            for(int i = 0; i < months; ++i)
            {
                double temp = double.Parse(Console.ReadLine());
                electro += temp;
            }
            water = months * 20;
            net = months * 15;
            double average = (electro + water + net) * 1.2;
            Console.WriteLine("Electricity: {0:f2} lv", electro);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", net);
            Console.WriteLine("Other: {0:f2} lv", average);
            Console.WriteLine("Average: {0:f2} lv", (average + electro + water + net )/ months);
        }
    }
}
