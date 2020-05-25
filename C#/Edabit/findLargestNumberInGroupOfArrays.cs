using System;
using System.Linq;
public class Program
{
    public static double[] FindLargest (double[][] values)
    {
        return values.Select (v => v.Max ()).ToArray ();
    }
}