using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{

    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, double> dataBase = new Dictionary<string, double>()
            {
                {"OutFall 4", 39.99},
                {"CS: OG", 15.99},
                {"Zplinter Zell", 19.99},
                {"Honored 2", 59.99},
                {"RoverWatch", 29.99},
                {"RoverWatch Origins Edition", 39.99}
            };
            double currBallance = double.Parse(Console.ReadLine());
            double startBallance = currBallance;
            string command = Console.ReadLine();
            List<string> stringsToPrint = new List<string>();
            bool isOutOfMoney = false;
            while(command != "Game Time")
            {
                if (dataBase.ContainsKey(command))
                {
                    double newBallance = currBallance - dataBase[command];
                    if(newBallance == 0)
                    {
                       
                        stringsToPrint.Add("Bought " + command);
                        stringsToPrint.Add("Out of Money");
                        isOutOfMoney = true;
                        break;
                    }
                    else if(newBallance < 0)
                    {
                        stringsToPrint.Add("Too Expensive");
                    }
                    else
                    {
                       
                        stringsToPrint.Add("Bought " + command);
                        currBallance = newBallance;
                    }
                }
                else
                {
                    stringsToPrint.Add("Not Found");
                }
                command = Console.ReadLine();
            }
            if(stringsToPrint.Count() != 0)
            {
                foreach( var iter in stringsToPrint)
                {
                    Console.WriteLine(iter);
                }

            }
            if (!isOutOfMoney)
            {

                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", startBallance - currBallance, currBallance);
            }

        }
    }
}


