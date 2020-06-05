using System.Text.RegularExpressions;
public class Kata
{
    public static string RemoveExclamationMarks (string s)
    {
        return Regex.Replace (s, "[!]", "");
    }
}