using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество двоек: ");
        long a = long.Parse(Console.ReadLine());

        Console.Write("Введите количество троек: ");
        long b = long.Parse(Console.ReadLine());

        Console.Write("Введите количество четверок: ");
        long c = long.Parse(Console.ReadLine());  

        long kvo = a + b + c;

        long sm = a * 2 + b * 3 + c * 4;

        long k = 0;

        while (sm*2 < 7*kvo)
        {
            k++;
            sm += 5;
            kvo ++;
        }

        Console.WriteLine(k);





    }
}