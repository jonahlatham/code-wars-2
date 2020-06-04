using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static string StringClean (string s)
    {
        return Regex.Replace (s, @"\d", "");
    }
}