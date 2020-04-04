using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int HammingDistance (string str1, string str2)
    {
        string[] num1 = str1.Split ("");
        string[] num2 = str2.Split ("");
        return num1.SequenceEqual (num2).Length;
    }
}