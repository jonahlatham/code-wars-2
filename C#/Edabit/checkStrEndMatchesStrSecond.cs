using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static bool CheckEnding (string str1, string str2)
    {
        return str1.Substring (str1.Length - str2.Length) == str2;
    }
}