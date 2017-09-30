using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reward
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyPerPoint = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            double totalPoints = 0;
            for(int i = 0; i < parts; ++i)
            {
                int currPoints = int.Parse(Console.ReadLine());
                if((i + 1) % 2 == 0)
                {
                    currPoints *= 2;
                }
                totalPoints += currPoints;
            }
            totalMoney = totalPoints * moneyPerPoint;
            Console.WriteLine("The project prize was {0:F2} lv.", totalMoney);
        }
    }
}
