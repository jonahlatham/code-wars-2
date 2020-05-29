using System;
using System.Linq;

public class Program
{
    public static string HighLow (string str)
    {
        var minStr = str.Split (" ").Min ();
        var maxStr = str.Split (" ").Max ();
        return maxStr + " " + minStr;
    }
}