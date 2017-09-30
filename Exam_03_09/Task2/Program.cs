using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

       
        static void Main(string[] args)
        {
            double incomeBGN = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScolarship = 0;
            double excellentScolarsship = 0;
           
            if(incomeBGN < minSalary && averageGrade > 4.5)
            {
                socialScolarship = 0.35 * minSalary;
            }
            if(averageGrade >= 5.5)
            {
                excellentScolarsship = averageGrade * 25;
            }
            if(socialScolarship != 0 || excellentScolarsship != 0)
            {

                if (excellentScolarsship >= socialScolarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excellentScolarsship));
                    return;
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialScolarship));
                    return;
                }
               
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
