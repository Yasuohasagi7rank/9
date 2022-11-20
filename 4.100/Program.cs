using System;

namespace _4._100
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            
            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            c = Convert.ToInt32(Console.ReadLine());

            double d = 0;

            if (a > b || a > c) d += a;
            if (b > a || b > c) d += b;
            if (c > b || c > a) d += c;

            Console.WriteLine($"Сумма двух наибольших чисел {d}");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
