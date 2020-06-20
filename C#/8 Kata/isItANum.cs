using System;
using System.Linq;
using System.Text.RegularExpressions;

public class CodeWars
{
    public static bool IsDigit (string s)
    {
        return double.TryParse (s, out var _);
    }
}