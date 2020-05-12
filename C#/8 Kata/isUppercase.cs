using System;
using System.Collections.Generic;
using System.Linq;

public static class StringExtensions
{
    public static bool IsUpperCase (this string text)
    {
        return text == text.ToUpper ();
    }
}