using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static int[] Between (int a, int b)
    {
        List<int> stuff = new List<int> ();
        for (int i = a; i <= b; i++)
        {
            stuff.Add (i);
        }
        return stuff.ToArray ();
    }
}