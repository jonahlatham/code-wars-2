using System;
using System.Linq;
public class Program
{
    public static double[] FindMinMax (double[] values)
    {
        return new double[] { values.Min (), values.Max () };
    }
}