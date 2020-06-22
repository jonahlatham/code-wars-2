using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static string AlternatingCaps (string str)
    {
        bool useCaps = true;
        var resultStr = new StringBuilder ();
        for (int i = 0; i < str.Length; i++)
        {
            var currentChar = str[i];
            if (currentChar == ' ')
            {
                resultStr.Append (currentChar);
            }
            else
            {
                var changedChar = useCaps ? Char.ToUpper (currentChar) : Char.ToLower (currentChar);
                useCaps = !useCaps;
                resultStr.Append (changedChar);
            }
        }
        return resultStr.ToString ();
    }
}