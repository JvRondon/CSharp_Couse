using System;
using System.Globalization;

namespace SOMA
{
    class Program
    {
        static void Main(string[] args) {

            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        
        }
    }
}
