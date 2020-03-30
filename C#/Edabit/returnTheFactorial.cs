using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int Factorial (int num)
    {
        if (num == 1)
            return 1;
        else
            return num * Factorial (num - 1);
    }
} 