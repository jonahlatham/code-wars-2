using System;
using System.Linq;

public class Program
{
    public static int[] ArrayOfMultiples (int num, int length)
    {
        return Enumerable.Range (1, length).Select (x => x * num).ToArray ();
    }
}