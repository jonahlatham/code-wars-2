using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static bool IsPalindrome (string str)
    {
        str = Regex.Replace (str.ToLower (), "[^a-z]", "");
        return str.SequenceEqual (str.Reverse ());
    }
}