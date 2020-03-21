using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static object[] RemoveDups (object[] str)
    {
        return str.Distinct ().ToArray ();
    }
}