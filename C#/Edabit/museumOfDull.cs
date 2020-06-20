using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int[] RemoveSmallest (int[] values)
    {
        if (values.Length > 0)
        {
            var crap = Array.IndexOf (values, values.Min ());
            return values.Where ((e, i) => i != crap).ToArray ();
        }
        else
        {
            return values;
        }
    }
}