using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfParticipants = int.Parse(Console.ReadLine());
            if (numberOfParticipants > 0)
            {


                Dictionary<string, double> dataBase = new Dictionary<string, double>();
                for (int i = 0; i < numberOfParticipants; ++i)
                {
                    int distanceInMiles = int.Parse(Console.ReadLine());
                    double cargoInTons = double.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    double earnedMoney = cargoInTons * 1000 * 1.5 - distanceInMiles * 1600 * 0.7 * 2.5;
                    if (!dataBase.ContainsKey(name))
                    {
                        dataBase.Add(name, earnedMoney);
                    }
                    else
                    {
                        dataBase[name] += earnedMoney;
                    }
                }
                var maxValue = dataBase.Values.Max();
                var maxKey = dataBase.FirstOrDefault(x => x.Value == maxValue).Key;
                Console.WriteLine("The {0} Trainers win with ${1:f3}.", maxKey, maxValue);
            }
            
        }
    }
}
