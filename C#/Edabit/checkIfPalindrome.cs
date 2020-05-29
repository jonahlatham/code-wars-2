using System;
using System.Linq;
public class Program
{
    public static bool IsPalindrome (int num)
    {
        return num == num.ToString ().Reverse ().Aggregate (0, (b, x) => 10 * b + x - '0');
    }
}