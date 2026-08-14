namespace Banking;

public class  Account{

    // Encapsulated Data members

    private float balance{get; set;}
    private int accountId;
    private string accountHolder;

    
    //constructor overloading

    //default constructor

    public Account(){
             this.accountId=76;
             accountHolder="Roshan Patil";
             balance=89000;

    }

    //Parameterized Constructor
    public Account(int id, string holder, float amount){
        accountId=id;
        accountHolder=holder;
        balance=amount;
    }


    public float GetBalance(){
        return balance;
    }


    public void SetBalance(float amount){
        balance=amount;
    }


    public void ShowBalance (){

        Console.WriteLine( "Balance =" + balance);
    }

    //Method overriding
    public override string ToString(){
      return   base.ToString() + "  " + accountId +"  " + accountHolder + " "+balance;
    }
}