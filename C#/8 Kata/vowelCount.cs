using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount (string str)
    {
        return str.Count (e => "aeiou".Contains (Char.ToLower (e)));
    }
}