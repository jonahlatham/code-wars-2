using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int CharCount (char myChar, string str)
    {
        int bitchLasagna = str.Count (f => f == myChar);
        return bitchLasagna;
    }
}