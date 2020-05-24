using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string FormatPhoneNumber (int[] numbers)
    {
        return string.Format ("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select (x => x.ToString ()).ToArray ());
    }
}