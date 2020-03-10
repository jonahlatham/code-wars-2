using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static int NumberSyllables (string word)
    {
        string[] syllables = word.Split ("-");
        return syllables.Length;
    }
}