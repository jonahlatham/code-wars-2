using System;
using System.Linq;
public class Program
{
    public static int MajorSum (int[] arr)
    {
        int x = arr.Where (c => c > 0).Sum ();
        int y = arr.Where (c => c < 0).Sum ();
        int z = arr.Where (c => c == 0).Count ();
        return Math.Abs (x) > Math.Abs (y) ? Math.Abs (x) > z ? x : z : Math.Abs (y) > z ? y : z;
    }
}