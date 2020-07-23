using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static bool IsSmooth (string sentence)
    {
        return Regex.Matches (
            sentence,
            @"([a-z]) (?!\1)",
            RegexOptions.IgnoreCase
        ).Count == 0;
    }
}