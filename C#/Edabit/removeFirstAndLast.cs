using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string RemoveFirstLast (string str)
    {
        return str.Substring (1) + str.Substring (0, 1);
    }
}