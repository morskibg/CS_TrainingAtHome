using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double buddget = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            int count = int.Parse(Console.ReadLine());
            while(count > 0)
            {
                string itemNAme = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemQty = int.Parse(Console.ReadLine());

                spentMoney += itemPrice * itemQty;
                if(itemQty > 1)
                {
                    itemNAme = itemNAme + "s";
                }
                Console.WriteLine("Adding {0} {1} to cart", itemQty, itemNAme);
                --count;
            }
            Console.WriteLine("Subtotal: ${0:f2}", spentMoney);
            if(buddget - spentMoney > 0)
            {
                Console.WriteLine("Money left: ${0:f2}", buddget - spentMoney);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", spentMoney - buddget);
            }
        }
    }
}
