using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static bool ArrayMadness (int[] a, int[] b)
    {
        return a.Sum (x => x * x) > b.Sum (x => x * x * x);
    }
}