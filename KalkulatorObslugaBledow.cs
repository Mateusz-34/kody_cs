using System;

class Kalkulator{
    static void Main(){
        while (true){
            try{
                Console.Write("Podaj pierwszą liczbę (lub q aby zakończyć): ");
                string input1 = Console.ReadLine();

                if (input1 == "q"){
                    break;
                }
                
                double a = double.Parse(input1);

                Console.Write("Podaj operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Podaj drugą liczbę (lub q aby zakończyć): ");
                string input2 = Console.ReadLine();

                if (input2 == "q"){
                    break;
                }
                
                double b = double.Parse(input2);

                double wynik;

                switch (op){
                    case "+":
                        wynik = a + b;
                        Console.WriteLine("Wynik: " + wynik);
                        break;

                    case "-":
                        wynik = a - b;
                        Console.WriteLine("Wynik: " + wynik);
                        break;

                    case "*":
                        wynik = a * b;
                        Console.WriteLine("Wynik: " + wynik);
                        break;

                    case "/":
                        if (b == 0){
                            throw new DivideByZeroException();
                        }
                        wynik = a / b;
                        Console.WriteLine("Wynik: " + wynik);
                        break;

                    default:
                        Console.WriteLine("Błąd: nieznany operator.");
                        break;
                }
            }
            catch (FormatException){
                Console.WriteLine("Błąd: wpisz poprawną liczbę.");
            }
            catch (DivideByZeroException){
                Console.WriteLine("Błąd: nie można dzielić przez 0.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Program zakończony.");
    }
}
