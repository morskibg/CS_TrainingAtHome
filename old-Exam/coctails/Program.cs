using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coctails
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double money = 1; ;
            switch (fruit)
            {
                case "Watermelon":
                    if(size == "big")
                    {
                        money = 5 * 28.7;
                    }
                    else
                    {
                        money = 2 * 56.0;
                    }
                    break;
                case "Mango":
                    if (size == "big")
                    {
                        money = 5 * 19.6;
                    }
                    else
                    {
                        money = 2 * 36.66;
                    }
                    break;
                case "Pineapple":
                    if (size == "big")
                    {
                        money = 5 * 24.8;
                    }
                    else
                    {
                        money = 2 * 42.1;
                    }
                    break;
                case "Raspberry":
                    if (size == "big")
                    {
                        money = 5 * 15.2;
                    }
                    else
                    {
                        money = 2 * 20.0;
                    }
                    break;
            }
            money *= count;
            if (money > 1000)
            {
                money /= 2;
            }
            else if (money >= 400)
            {
                money *= 0.85;
            }
            Console.WriteLine("{0:F2} lv.", money);
        }
    }
}
