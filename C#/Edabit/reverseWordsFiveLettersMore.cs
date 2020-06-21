using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string Reverse (string str)
    {
        return string.Join (" ", str.Split (' ').Select (w => w.Length > 4 ? string.Concat (w.Reverse ()) : w));
    }
}