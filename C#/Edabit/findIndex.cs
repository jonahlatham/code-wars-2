using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int FindIndex (string[] arr, string str)
    {
        int a = Array.IndexOf (arr, str);
        return a;
    }
}