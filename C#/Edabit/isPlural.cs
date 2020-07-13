using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static bool IsPlural (string word)
    {
        return word.Substring (word.Length - 1) == "s";
    }
}