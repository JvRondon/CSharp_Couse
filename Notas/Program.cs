using System;

namespace Notas {
    class Program{
        static void Main(string[] args){
            int N, quociente, resto, notas ;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            notas = 100;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            notas = 50;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            notas = 20;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            notas = 10;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            notas = 5;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            notas = 2;
            quociente = resto / notas;
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ",00");
            resto = resto % notas;

            Console.WriteLine(resto + " nota(s) de R$1,00");
        }
    }
}