using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static bool IsValid (string zip)
    {
        return zip.All (c => char.IsDigit (c)) && zip.Length == 5;
    }
}