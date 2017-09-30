using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edno
{
    class Program
    {
        const double WorkPlaceL = 120.0;
        const double WorkPlaceW = 70.0;
        const double PassWidth = 100.0;
        const int WorkPlacesToRemove = 3;
        static void Main(string[] args)
        {
            var HallLength = double.Parse(Console.ReadLine()) * 100;
            var HallWidth = double.Parse(Console.ReadLine()) * 100;
            var RealHallWidth = HallWidth - PassWidth;
            int LengthWorkPlaces = 0;
            while(HallLength - WorkPlaceL >= 0)
            {
                ++LengthWorkPlaces;
                HallLength -= WorkPlaceL;
            }
            int WidthWorkPlaces = 0;
            while(RealHallWidth - WorkPlaceW >= 0)
            {
                ++WidthWorkPlaces;
                RealHallWidth -= WorkPlaceW;
            }
            int TotalWorkPlaces = LengthWorkPlaces * WidthWorkPlaces - WorkPlacesToRemove;
            Console.WriteLine(TotalWorkPlaces);
        }
    }
}
