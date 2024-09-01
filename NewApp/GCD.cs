
using System;

class MAIN 
{
    static void Main(string[] args)
    {
        int a = 56;
        int b = 77;
        Console.WriteLine("GDC двух чисел: {0} и {1} равно -> {2}", a, b, GCD(a, b));
    }

    static int GCD(int a, int b)
    {
        if (b == 0) {
            return a;
        }
        return GCD(b, a % b);

    }
}