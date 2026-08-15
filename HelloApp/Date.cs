namespace Banking;

public class Date
{
    private int day;
    private int month;
    private int year;


    public Date(){
        day=22;
        month=3;
        year=26;
    }
    public Date(int day,int month,int year){
       this.day= day;
        this.month=month;
        this.year=year;
    }
    public void Display(){
         Console.WriteLine("date :"+ day+"/"+month+"/"+year);
    }
}