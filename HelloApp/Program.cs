namespace   Transflower;
using Banking;
using CRM;
using Catalog;


public class Program{

    //Entry Point function

    public static void Main(string [] args)
    {

    int count=56;
    count ++;
    char ch='A';

    bool status=false;
    double price=56.6;

     Console.WriteLine("Welcome to Transflower");

    //Create two instances from Account class

     Account acct =new Account();
     
     Date sec =new Date();
     Date sec2 =new Date(12 , 4, 26);
     Account acct2=new Account(12,"Ravi Tambade", 670000);

     Console.WriteLine(acct);
     Console.WriteLine(acct2);
     Console.WriteLine(sec);
     Console.WriteLine(sec2);
     sec.Display();
     sec2.Display();
    }
}
