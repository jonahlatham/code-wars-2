using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
    public static object[] RemoveEveryOther (object[] arr)
    {
        return arr.Where ((e, i) => i % 2 == 0).ToArray ();
    }
}