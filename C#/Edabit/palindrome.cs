public class Program
{
    public static bool CheckPalindrome (string str)
    {
        return str == string.Concat (str.Reverse ());
    }
}