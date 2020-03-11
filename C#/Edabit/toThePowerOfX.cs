using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static long CalculateExponent (long number, long exponent)
    {
        return Convert.ToInt64 (Math.Pow (number, exponent));
    }
}