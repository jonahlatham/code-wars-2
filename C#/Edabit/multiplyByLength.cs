using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int[] MultiplyByLength (int[] arr)
    {
        return arr.Select (e => e * arr.Length).ToArray ();
    }
}