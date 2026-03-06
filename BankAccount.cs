using System;

class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount b = new BankAccount();
        b.Balance = 100;
        b.Deposit(50);
        Console.WriteLine(b.Balance);
    }
}