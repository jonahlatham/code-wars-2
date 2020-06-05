using System.Text.RegularExpressions;
public class Program
{
    public static bool ValidateEmail (string str)
    {
        return Regex.IsMatch (str, @"\w+@\w+\.\w+");
    }
}