using System;
using System.Linq;
public class Program
{
    public static string Maskify (string str)
    {
        return str.Length <= 4 ?
            str :
            $"{new string('#', str.Length - 4)}{str.Substring(str.Length - 4)}";
    }
}