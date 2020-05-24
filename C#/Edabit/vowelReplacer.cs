using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static string ReplaceVowels (string str, string ch)
    {
        var r = new Regex ("[aeiouy]");
        return r.Replace (str, ch);
    }
}