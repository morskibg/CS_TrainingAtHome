using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitConverter
{
    class Program
    {
        const double mTOmm = 1000;
        const double mTOcm = 100;
        const double mTOmi = 0.000621371192;
        const double mTOin = 39.3700787;
        const double mTOkm = 0.001;
        const double mTOft = 3.2808399;
        const double mTOyd = 1.0936133;

        static void Main(string[] args)
        {
            var inputNum = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            double fromRatio = 1, toRatio = 1;
            switch (from)
            {
                case "mm":
                    fromRatio = 1 / mTOmm;
                    break;
                case "cm":
                    fromRatio = 1 / mTOcm;
                    break;
                case "mi":
                    fromRatio = 1 / mTOmi;
                    break;
                case "in":
                    fromRatio = 1 / mTOin;
                    break;
                case "km":
                    fromRatio = 1 / mTOkm;
                    break;
                case "ft":
                    fromRatio = 1 / mTOft;
                    break;
                case "yd":
                    fromRatio = 1 / mTOyd;
                    break;
                default:
                    fromRatio = 1;
                    break;
            }
            switch (to)
            {
                case "mm":
                    toRatio = mTOmm;
                    break;
                case "cm":
                    toRatio = mTOcm;
                    break;
                case "mi":
                    toRatio = mTOmi;
                    break;
                case "in":
                    toRatio = mTOin;
                    break;
                case "km":
                    toRatio = mTOkm;
                    break;
                case "ft":
                    toRatio = mTOft;
                    break;
                case "yd":
                    toRatio = mTOyd;
                    break;
                default:
                    toRatio = 1;
                    break;
            }
            double result = inputNum * fromRatio * toRatio;
            Console.WriteLine(result);

        }
    }
}
