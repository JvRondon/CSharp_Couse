using System;

namespace Age{
    class Program{
        static void Main(string[] args){
            int N, anos, meses, dias, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " anos(s)");
            Console.WriteLine(anos + " mes(s)");
            Console.WriteLine(anos + " dia(s)");

        }
    }
}