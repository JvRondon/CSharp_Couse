using System;

namespace PRODUTO {
    class Program {
        static void Main(string[] args) {

            int X, Y, Prod;
            
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Prod = X * Y;

            Console.WriteLine("Produto é = " + Prod);
        
        }
    }
}