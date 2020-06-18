using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static string FormatPhone (long str)
    {
        return String.Format ("{0:(###) ###-####}", str);
    }
    public static bool IsValidPhoneNumber (string str)
    {
        return Regex.Match (str, @"^\(\d{3}\)\s\d{3}-\d{4}$").Success;
    } 
}