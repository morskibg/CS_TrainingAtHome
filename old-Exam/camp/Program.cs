using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var group = Console.ReadLine();
            var sudents = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            bool isBoys = false, isGirls = false;//, isMixed = false;
           // bool isWinter = false, isSummer = false, isSpring = false;
            string currentSport = "";
            double price = 0;
            switch (group)
            {
                case "boys":
                    isBoys = true;
                    break;
                case "girls":
                    isGirls = true;
                    break;
                case "mixed":
                    //isMixed = true;
                    break;
            }
            
            switch (season)
            {
                case "Winter":
                    price = 9.6;
                    if (isBoys)
                    {
                        currentSport = "Judo";
                    }
                    else if (isGirls)
                    {
                        currentSport = "Gymnastics";
                    }
                    else
                    {
                        currentSport = "Ski";
                        price = 10;
                    }
                    break;
                case "Spring":
                    price = 7.2;
                    if (isBoys)
                    {
                        currentSport = "Tennis";
                    }
                    else if (isGirls)
                    {
                        currentSport = "Athletics";
                    }
                    else
                    {
                        currentSport = "Cycling";
                        price = 9.5;
                    }
                    break;
                case "Summer":
                    price = 15.0;
                    if (isBoys)
                    {
                        currentSport = "Football";
                    }
                    else if (isGirls)
                    {
                        currentSport = "Volleyball";
                    }
                    else
                    {
                        currentSport = "Swimming";
                        price = 20.0;
                    }
                    break;
            }
            double discout = 1;
            if(sudents >= 50)
            {
                discout = 0.5;
            }
            else if(sudents >= 20)
            {
                discout = 0.85;
            }
            else if(sudents >= 10)
            {
                discout = 0.95;
            }
            double total_price = nights * sudents * price * discout;
            Console.WriteLine("{0} {1:F2} lv.", currentSport, total_price);
        }
    }
}
