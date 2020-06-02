using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
    public static string Remove (string s)
    {
        return s.TrimEnd ('!');
    }
}