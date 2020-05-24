using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int CountWords (string str)
    {
        return str.Split (' ').ToList ().Count;
    }
}