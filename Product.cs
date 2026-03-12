using System;

public class Produkt
{
    public string nazwa;
    public double cena;
    public string producent;

    public Produkt(string nazwa, double cena, string producent)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        this.producent = producent;
    }

    public virtual void WyswietlInformacje()
    {
        Console.WriteLine("=== PRODUKT RTV ===");
        Console.WriteLine(nazwa);
        Console.WriteLine(producent);
        Console.WriteLine(cena);
        Console.WriteLine(" ");
    }
}

public class Telewizor : Produkt
{
    public int przekatnaEkranu;
    public bool smartTV;

    public Telewizor(string nazwa, double cena, string producent, int przekatnaEkranu, bool smartTV) : base(nazwa, cena, producent)
    {
        this.przekatnaEkranu = przekatnaEkranu;
        this.smartTV = smartTV;
    }

    public override void WyswietlInformacje()
    {
        Console.WriteLine("=== PRODUKT RTV ===");
        Console.WriteLine(nazwa);
        Console.WriteLine(producent);
        Console.WriteLine(cena);
        Console.WriteLine(przekatnaEkranu);
        Console.WriteLine(smartTV);
        Console.WriteLine(" ");
    }
}

public class Laptop : Produkt
{
    public int RAM;
    public string Procesor;

    public Laptop(string nazwa, double cena, string producent, int RAM, string Procesor) : base(nazwa, cena, producent)
    {
        this.RAM = RAM;
        this.Procesor = Procesor;
    }

    public override void WyswietlInformacje()
    {
        Console.WriteLine("=== PRODUKT RTV ===");
        Console.WriteLine(nazwa);
        Console.WriteLine(producent);
        Console.WriteLine(cena);
        Console.WriteLine(RAM);
        Console.WriteLine(Procesor);
        Console.WriteLine(" ");
    }
}

class Program
{
    static void Main()
    {
        Telewizor Tv1 = new Telewizor("Samsung QLED55", 3200, "Samsung", 55, true);
        Telewizor Tv2 = new Telewizor("LG OLED65", 4100, "LG", 65, true);
        Laptop Laptop1 = new Laptop("Lenovo Legion5", 4500, "Lenovo", 16, "Ryzen 7");
        Laptop Laptop2 = new Laptop("Asus TUF15", 3500, "Asus", 16, "Intel i5");

        Tv1.WyswietlInformacje();
        Tv2.WyswietlInformacje();
        Laptop1.WyswietlInformacje();
        Laptop2.WyswietlInformacje();
    }
}