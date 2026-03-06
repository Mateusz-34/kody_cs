using System;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine("Cześć, mam na imię " + Name + " i mam " + Age + " lat.");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Jan";
        p.Age = 20;
        p.Introduce();
    }
}