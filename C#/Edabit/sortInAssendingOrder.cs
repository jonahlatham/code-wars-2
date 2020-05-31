using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int[] SortNumsAscending (int[] arr)
    {
        return arr.OrderBy (x => x).ToArray ();
    }
}