using System;

class Vehicle
{
    public string Brand { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Pojazd uruchomiony");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Samochód odpala silnik");
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Car();
        v.Start();
    }
}