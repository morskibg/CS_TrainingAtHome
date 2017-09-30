using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    
    class Program
    {
        //текст "Spring", "Summer", "Autumn" или "Winter"
        public static double FindPrice(double km, string season)
        {
           if(km <= 5000)            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        return 0.75;                       
                    case "Summer":
                        return 0.90;                        
                    case "Winter":
                        return 1.05;
                    default:
                        return -1;                    
                }
            }
           else if( km > 5000 && km <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        return 0.95;
                    case "Summer":
                        return 1.1;
                    case "Winter":
                        return 1.25;
                    default:
                        return -1;
                }
            }
           else if(km > 10000 && km <= 20000)
            {
                return 1.45;
            }
            else
            {
                return -1;
            }        
        }
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonht = double.Parse(Console.ReadLine());
            double pricePerKm = FindPrice(kmPerMonht, season);
            Console.WriteLine("{0:F2}", pricePerKm * kmPerMonht * 0.9 * 4);
            
        }
    }
}
