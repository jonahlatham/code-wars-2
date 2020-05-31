using System.Linq;
using System;

public class Program 
{
    public static int SortDescending(int num) 
    {
      return Convert.ToInt32(String.Concat(num.ToString().OrderByDescending(c => c)));
    }
}