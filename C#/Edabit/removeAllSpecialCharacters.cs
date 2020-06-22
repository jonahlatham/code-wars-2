using System.Text.RegularExpressions;
public class Program
{
    public static string RemoveSpecialCharacters (string str)
    {
        return Regex.Replace (str, "[^0-9A-Za-z _-]", "");
    }
}