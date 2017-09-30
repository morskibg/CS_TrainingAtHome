using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int photoDay = int.Parse(Console.ReadLine());
            int photoMonth = int.Parse(Console.ReadLine());
            int photoYear = int.Parse(Console.ReadLine());
            int photoHours = int.Parse(Console.ReadLine());
            int photoMinutes = int.Parse(Console.ReadLine());
            int photoSize = int.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            //DateTime photoData = new DateTime(photoYear, photoMonth, photoDay, photoHours, photoMinutes, 0);
            int leadingZeroes = 0;
            if(photoNumber < 10)
            {
                leadingZeroes = 3;
            }
            else if (photoNumber < 100)
            {
                leadingZeroes = 2;
            }
            else if(photoNumber < 1000)
            {
                leadingZeroes = 1;
            }
            string hours = photoHours.ToString();
            string minutes = photoMinutes.ToString();
            string days = photoDay.ToString();
            string months = photoMonth.ToString();
            if (photoMonth < 10)
            {
                months = "0" + photoMonth.ToString();
            }
            if (photoDay < 10)
            {
                days = "0" + photoDay.ToString();
            }
            ////////////////////////////////
            if (photoHours < 10)
            {
                hours = "0" + photoHours.ToString();
            }
            if(photoMinutes < 10)
            {
                minutes = "0" + photoMinutes.ToString();
            }
            string time = days + "/" + months + "/" + photoYear.ToString() + " " + hours + ":" + minutes;
            string nameNumber = photoNumber.ToString();
            while(leadingZeroes != 0)
            {
                nameNumber = "0" + nameNumber;
                --leadingZeroes;
            }
            string size = photoSize.ToString() + "B";
            if(photoSize > 1000000)
            {
                double temp = Math.Round(photoSize / 1000000.0, 1);
                size = temp.ToString() + "MB";
            }
            else if (photoSize > 1000)
            {
                double temp = Math.Round(photoSize / 1000.0, 1);
                size = temp.ToString() + "kB";
            }
            
            Console.WriteLine("Name: DSC_{0}.jpg", nameNumber);
            Console.WriteLine("Date Taken: {0}",time);
            Console.WriteLine("Size: {0}", size);
            string orientation = "(landscape)";
            if(photoWidth < photoHeight)
            {
                orientation = "(portrait)";
            }
            else if(photoHeight == photoWidth)
            {
                orientation = "(square)";
            }
            Console.WriteLine("Resolution: {0}x{1} {2}", photoWidth, photoHeight, orientation);

        }
    }
}
