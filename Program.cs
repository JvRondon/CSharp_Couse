using System;
using System.Globalization;

namespace primeiro_projeto{
    class Program{
        static void Main(string[] args) {

            double A, R, pi = 3.14159;

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
