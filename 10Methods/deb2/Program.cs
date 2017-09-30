using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double prevPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currPrice = double.Parse(Console.ReadLine());
            double differenceInPercentage = CalcDiffInPerecents(prevPrice, currPrice);
            bool isSignificantDifference = isDiff(differenceInPercentage, threshold);
            string message = Get(currPrice, prevPrice, differenceInPercentage, isSignificantDifference);
            Console.WriteLine(message);
            prevPrice = currPrice;
        }
    }

    private static string Get(double currPrice, double prevPrice, double difInPercentage, bool isSignificantDifference)
    {
        string to = "";
        if (difInPercentage == 0)
        {
            to = string.Format("NO CHANGE: {0}", currPrice);
        }
        else if (!isSignificantDifference)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prevPrice, currPrice, difInPercentage);
        }
        else if (isSignificantDifference && (difInPercentage > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prevPrice, currPrice, difInPercentage);
        }
        else if (isSignificantDifference && (difInPercentage < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prevPrice, currPrice, difInPercentage);
        return to;
    }
    private static bool isDiff(double differenceInPercentage, double threshold)
    {
        if (Math.Abs(differenceInPercentage) >= threshold * 100)
        {
            return true;
        }
        return false;
    }

    private static double CalcDiffInPerecents(double price1, double price2)
    {
        double difInPercents = (price2 - price1) / price1 * 100;
        return difInPercents;
    }
}
