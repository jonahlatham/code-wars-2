using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string NameShuffle (string str)
    {
        return string.Join (" ", str.Split (' ').Reverse ());
    }
}