using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Cześć, mam na imię " + Name + " i mam " + Age + " lat.");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Anna", 25);
        p.Introduce();
    }
}