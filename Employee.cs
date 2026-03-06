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
}

class Employee : Person
{
    public double Salary;

    public Employee(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " " + Age + " " + Salary);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee("Jan", 30, 5000);
        e.ShowInfo();
    }
}