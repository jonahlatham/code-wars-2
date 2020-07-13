using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static bool HasSpaces (string str)
    {
        return str.Replace (" ", "") != str;
    }
}