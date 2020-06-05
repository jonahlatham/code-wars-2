using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static long Fact (int n)
    {
        long total = 1;
        for (int i = n; i > 0; i--)
        {
            total *= i;
        }
        return total;
    }
}