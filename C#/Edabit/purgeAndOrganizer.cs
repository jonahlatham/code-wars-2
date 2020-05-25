using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static double[] UniqueSort (double[] arr)
    {
        Array.Sort (arr);
        return arr.ToList ().Distinct ().ToArray ();
    }
}