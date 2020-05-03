using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static bool IsIsogram (string str)
    {
        var stringers = new string (str.ToLower ().ToCharArray ().Distinct ().ToArray ());
        return str.Length == stringers.Length;
    }
}