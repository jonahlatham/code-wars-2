using System;
using System.Text.RegularExpressions;
public class Kata
{
    public static string Shortcut (string input)
    {
        return Regex.Replace (input, "[aeiou]", "");
    }
}
// using System;
// using System.Linq;
// public class Kata
// {
//     public static string Shortcut (string input)
//     {
//         char[] result = input.ToCharArray ();
//         return String.Join ("", result.Where (x => x != 'a' && x != 'e' && x != 'i' && x != 'o' && x != 'u'));
//     }
// }