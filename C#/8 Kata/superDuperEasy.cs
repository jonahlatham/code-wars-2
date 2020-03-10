using System;

public class Kata
{
    public static string Problem (String a)
    {
        var crap = int.TryParse (a, out int p);
        if (crap)
        {
            return ((Int32.Parse (a) * 50) + 6).ToString ();
        }
        else
        {

            return "Error";
        }
    }
}