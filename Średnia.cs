using System;

class Średnia{
    static void Main(){
        int[] liczby = new int[5];
        int suma = 0;

        for (int i = 0; i < 5; i++){
            Console.Write("Podaj liczbę " + (i + 1) + ": ");
            liczby[i] = int.Parse(Console.ReadLine());
            suma += liczby[i];
        }

        double srednia = (double)suma / 5;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Średnia: " + srednia);
    }
}