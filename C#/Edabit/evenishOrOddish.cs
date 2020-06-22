using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string OddishOrEvenish (int num)
    {
        int total = 0;
        while (num > 0)
        {
            total += num % 10;
            num /= 10;
        }

        return total % 2 == 0 ? "Evenish" : "Oddish";
    }
}