using System.Text.RegularExpressions;
public class Program
{
    public static string RemoveVowels (string str)
    {
        var r = new Regex ("[aeiou]");
        return r.Replace (str, "");
    }
}