using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    // public static string TranslateWord (string word)
    // {
    //     return string.Join ("", word.Substring (1) + word[0] + "ay");
    // }

    public static string TranslateWord (string word)
    {
        return word.Substring (1) + word[0] + "ay";
    }

    public static string TranslateSentence (string sentence)
    {
        var r = new Regex ("[aeiouy]");
        return sentence[0].Contains (r) ? sentence + "yay" : sentence;
    }
}