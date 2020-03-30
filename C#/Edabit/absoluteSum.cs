using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int GetAbsSum (int[] arr)
    {
        var newArr1 = arr.Where (e => e > 0);
        var newArr2 = arr.Where (e => e < 0);
        var newArr3 = newArr2.Select (e => e * -1);
        return newArr1.Sum () + newArr3.Sum ();
    }
}