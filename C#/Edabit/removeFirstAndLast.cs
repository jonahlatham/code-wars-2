using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string RemoveFirstLast (string str)
    {
        return str.Length <= 2 ? str : str.Substring (1, str.Length - 2);
    }
}