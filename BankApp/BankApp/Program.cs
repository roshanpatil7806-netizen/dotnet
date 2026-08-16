
using System;
class Program
{
    static void Main(string[] args)
    {
        Bank b = new Bank("Roshan", 12345, 5000);

        b.Display();

        b.Deposit(2000);
        b.Display();

        b.Withdraw(1000);
        b.Display();
    }
}