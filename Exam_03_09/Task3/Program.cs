using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            string orderType = Console.ReadLine();
            double totalPrice = 0;
            switch (format)
            {
                case "9X13":
                    totalPrice = pictures * 0.16;
                    if(pictures >= 50)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
                case "10X15":
                    totalPrice = pictures * 0.16;
                    if (pictures >= 80)
                    {
                        totalPrice *= 0.97;
                    }
                    break;
                case "13X18":
                    totalPrice = pictures * 0.38;
                    if (pictures >= 50 && pictures <= 100)
                    {
                        totalPrice *= 0.97;
                    }
                    else if (pictures > 100)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
                case "20X30":
                    totalPrice = pictures * 2.9;
                    if (pictures >= 10 && pictures <= 50)
                    {
                        totalPrice *= 0.93;
                    }
                    else if (pictures > 50)
                    {
                        totalPrice *= 0.91;
                    }
                    break;
            }
            if(orderType == "online")
            {
                totalPrice *= 0.98;
            }
            Console.WriteLine("{0:f2}BGN", totalPrice);
        }
    }
}
