using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static string LettersOnly (string str)
    {
        return Regex.Replace (str, @"[^a-zA-Z]+", String.Empty);
    }
}