using System;
using System.Linq;
public class Program
{
    public static string GetMiddle (string str)
    {
        return str.Substring ((str.Length - 1) / 2, 2 - (str.Length % 2));
    }
}