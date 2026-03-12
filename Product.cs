using System;

public class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    public string Producent { get; set; }

    public Produkt(string nazwa, double cena, string producent)
    {
        Nazwa = nazwa;
        Cena = cena;
        Producent = producent;
    }

    public virtual void WyswietlInformacje()
    {
        Console.WriteLine(Nazwa);
        Console.WriteLine(Cena);
        Console.WriteLine(Producent);
    }
}

class Program
{
    static void Main()
    {
        Produkt p = new Produkt("Telefon", 999.99, "Samsung");
        p.WyswietlInformacje();
    }
}