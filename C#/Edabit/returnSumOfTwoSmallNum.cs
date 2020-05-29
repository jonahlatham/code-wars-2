using System;
using System.Linq;
public class Program
{
    public static int SumSmallest (int[] values)
    {
        return values.Where (x => x >= 0).OrderBy (x => x).Take (2).Sum ();
    }
}