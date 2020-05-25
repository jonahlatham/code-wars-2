using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int[] IndexOfCapitals (string str)
    {
        return str.Select ((x, i) => i).Where (i => char.IsUpper (str[i])).ToArray ();
    }
}