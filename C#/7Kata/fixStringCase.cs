using System;
using System.Collections.Generic;
using System.Linq;

class Kata
{
    public static string Solve (string s)
    {
        return s.Count (char.IsLower) < s.Length / 2 ? s.ToUpper () : s.ToLower ();
    }
}