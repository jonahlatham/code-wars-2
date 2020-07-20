using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static string ount_all (string txt)
    {
        var digits = txt.Count (char.IsDigit);
        var letters = txt.Count (char.IsLetter);
        return Convert.ToString (new { LETTERS = letters, DIGITS = digits });
    }

    // public static string ount_all (string txt)
    // {
    //     var str = string.Join ("", Regex.Replace (txt, @"[\d-]", string.Empty).Length);
    //     var num = string.Join ("", Regex.Replace (txt, "[A-Za-z ]", string.Empty).Length);
    //     return "LETTERS = " + str + "," + " NUMBERS = " + num;
    // }
}