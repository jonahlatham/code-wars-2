using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static bool ArrayMadness (int[] a, int[] b)
    {
        return a.Sum (x => x * x) > b.Sum (x => x * x * x);
    }

    public static bool ArrayMadness2 (int[] a, int[] b)
    {
        return a.Sum (t => Math.Pow (t, 2)) > b.Sum (t => Math.Pow (t, 3));
    }

    public static bool ArrayMadness (int[] a, int[] b)
    {
        return a.Select (i => i * i).Sum () > b.Select (z => z * z * z).Sum ();
    }
}