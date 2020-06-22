public class Program
{
    public static string FlipEndChars (object str)
    {
        string text = str as string;
        if (text == null || text.Length < 2) return "Incompatible.";
        if (text[0] == text[text.Length - 1]) return "Two's a pair.";
        return $"{text[text.Length-1]}{text.Substring(1,text.Length-2)}{text[0]}";
    }
}