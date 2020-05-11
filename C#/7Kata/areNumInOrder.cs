using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static bool IsAscOrder (int[] arr)
    {
        return arr == Array.Sort (arr).ToList ();
    }
}