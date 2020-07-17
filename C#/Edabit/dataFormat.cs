using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    /* Their Solution */
    public static string FormatDate (string date)
    {
        DateTime inputDate = DateTime.Parse (date);
        return inputDate.ToString ("yyyydMM");
    }

    /* Mine */
    // public static string FormatDate (string date)
    // {
    //     return string.Join ("", date.Split ("/").Reverse ());
    // }
}