using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int FindLargestNum (int[] arr)
    {
        Array.Sort (arr);
        return arr[arr.Length - 1];
    }
}