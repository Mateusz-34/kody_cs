using System;

class Kalkulator{
    static void Main(){
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj znak operacji (+, -, *, /): ");
        char operacja = char.Parse(Console.ReadLine());

        switch (operacja){
            case '+':
                Console.WriteLine("Wynik: " + (a + b));
                break;

            case '-':
                Console.WriteLine("Wynik: " + (a - b));
                break;

            case '*':
                Console.WriteLine("Wynik: " + (a * b));
                break;

            case '/':
                if (b == 0)
                    Console.WriteLine("Nie można dzielić przez 0!");
                else
                    Console.WriteLine("Wynik: " + (a / b));
                break;

            default:
                Console.WriteLine("Niepoprawny znak operacji!");
                break;
        }
    }
}