using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int GetAbsSum (int[] arr)
    {
        List<int> newArr = arr.Select (e => e * -1);
        return newArr.Sum ();
    }
}