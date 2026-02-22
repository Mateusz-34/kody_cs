using System;

class CzyParzysta{
    static void Main(){
        Console.Write("Podaj liczbę całkowitą: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Liczba jest parzysta.");
        else
            Console.WriteLine("Liczba jest nieparzysta.");

        if (n > 0)
            Console.WriteLine("Liczba jest dodatnia.");
        else if (n < 0)
            Console.WriteLine("Liczba jest ujemna.");
        else
            Console.WriteLine("Liczba jest równa zero.");
    }
}