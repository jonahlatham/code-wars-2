using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Remove_char (string s)
    {
        return s.Substring (1).Remove (s.Length - 2);
    }
}