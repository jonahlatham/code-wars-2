using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string FormatDate (string date)
    {
        return string.Join ("", date.Split ("/").Reverse ());
    }
}