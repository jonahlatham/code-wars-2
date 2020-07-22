using System.Text.RegularExpressions;

public class Program
{
    public static string TextToNum (string phone)
    {
        phone = Regex.Replace (phone, "[ABC]", "2");
        phone = Regex.Replace (phone, "[DEF]", "3");
        phone = Regex.Replace (phone, "[GHI]", "4");
        phone = Regex.Replace (phone, "[JKL]", "5");
        phone = Regex.Replace (phone, "[MNO]", "6");
        phone = Regex.Replace (phone, "[PQRS]", "7");
        phone = Regex.Replace (phone, "[TUV]", "8");
        phone = Regex.Replace (phone, "[WXYZ]", "9");

        return phone;
    }
}