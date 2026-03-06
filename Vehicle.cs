using System;

class Vehicle
{
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine("Pojazd uruchomiony");
    }
}

class Car : Vehicle
{
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Start();
    }
}