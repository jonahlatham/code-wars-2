using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class Kata
{
    public static string TripleTrouble (string one, string two, string three)
    {
        return string.Concat (one.Select ((x, i) => x.ToString () + two[i] + three[i]));
    }
}