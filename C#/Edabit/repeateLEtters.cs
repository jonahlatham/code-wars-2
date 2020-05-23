using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string Repeat (string str, int num)
    {
        return Regex.Replace (str, ".", string.Concat (Enumerable.Repeat ("$0", num)));
    }
    // public static string Repeat (string str, int num)
    // {
    //     var crap = "";
    //     foreach (var item in str)
    //     {
    //         int i = 0;
    //         while (i < num)
    //         {
    //             crap += (item);
    //             i++;
    //         }
    //     }
    //     return crap;
    // }
}