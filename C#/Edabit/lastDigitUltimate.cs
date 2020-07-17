using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static bool last_dig (int a, int b, int c)
    {
        return a * b % 10 == c % 10;
    }
}