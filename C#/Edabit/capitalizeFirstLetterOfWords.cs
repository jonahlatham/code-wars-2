using System;
using System.Linq;
public class Program
{
    public static string MakeTitle (string str)
    {
        return string.Join (" ", str.Split (' ').Select (s => char.ToUpper (s[0]) + s.Substring (1)));
    }
}