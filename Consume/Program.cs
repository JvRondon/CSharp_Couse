using System;
using System.Globalization;

namespace Consume
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, kml;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml = (double)x / y;

            Console.WriteLine(kml.ToString("F3", CultureInfo.InvariantCulture) + "KM/L");
        }
    }
}
