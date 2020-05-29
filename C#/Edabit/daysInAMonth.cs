using System;
public class Program
{
    public static int Days (int month, int year)
    {
        return DateTime.DaysInMonth (year, month);
    }
}