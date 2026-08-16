namespace System;

class Bank
{
    string name;
    int accountNumber;
    double balance;

    public Bank(string name, int accountNumber, double balance)
    {
        this.name = name;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Money deposited successfully.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            Console.WriteLine("Money withdrawn successfully.");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }
}


