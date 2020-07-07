using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string[] CapMe (string[] arr)
    {
        return arr.Select (e => e[0].ToString ().ToUpper () + e.Substring (1).ToLower ()).ToArray ();
    }
}