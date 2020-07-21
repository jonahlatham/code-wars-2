using System;
using System.Collections;
using System.Linq;
using static System.Math;

public class Program
{
    public static bool IsPrime (int value)
    {
        if (value < 2) return false;
        if (value == 2) return true;
        if (value % 2 == 0) return false;

        for (int i = 3; i <= (int) Sqrt (value); i += 2)
            if (value % i == 0) return false;

        return true;
    }
}