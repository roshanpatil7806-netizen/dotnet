namespace System;
public class LeapYear
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public LeapYear(int day, int month, int year)
    {
        this.Day = day;
        this.Month = month;
        this.Year = year;
    }

    public void Show()
    {
        Console.WriteLine($"{Day}/{Month}/{Year}");
    }

   public void IsLeapYear()
    {
        if (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0))
        {
            Console.WriteLine($"{Year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{Year} is not a Leap Year");
        }
}
}