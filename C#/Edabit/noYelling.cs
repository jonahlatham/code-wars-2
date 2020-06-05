using System.Text.RegularExpressions;

public class Program
{
    public static string NoYelling (string phrase)
    {
        return Regex.Replace (phrase, @"([?|!])\1*$", @"$1"); // removes all but one
    }
}