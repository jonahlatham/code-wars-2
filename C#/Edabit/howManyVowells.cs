using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int CountVowels (string str)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        return str.Count (c => vowels.Contains (c));
    }
}