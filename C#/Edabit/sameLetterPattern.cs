using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static bool SameLetterPattern (string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1.IndexOf (str1.Substring (i, 1), i + 1) != str2.IndexOf (str2.Substring (i, 1), i + 1)) return false;
        }
        return true;
    }

}