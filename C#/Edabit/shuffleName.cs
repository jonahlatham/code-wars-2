using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string NameShuffle (string str)
    {
        string[] name = str.Split (" ");
        return String.Join (name.Reverse ());
    }
}