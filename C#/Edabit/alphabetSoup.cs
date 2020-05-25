using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string AlphabetSoup (string str)
    {
        return new string (str.OrderBy (x => x).ToArray ());
    }
}