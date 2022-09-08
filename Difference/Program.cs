using System;

class Difference
{

    static void Main(string[] args)
    {

        int A, B, C, D, Tt;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        Tt = (A * B - C * D);

        Console.WriteLine(Tt);

    }

}