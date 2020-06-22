using System.Linq;

public class Program
{
    public static bool IsStrangePair (string str1, string str2)
    {
        if (string.IsNullOrEmpty (str1) || string.IsNullOrEmpty (str2))
        {
            return str1 == str2;
        }

        return str1.First () == str2.Last () &&
            str2.First () == str1.Last ();
    }
}