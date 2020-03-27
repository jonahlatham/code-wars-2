using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string smallerNum (string n1, string n2)
    {
        if (Int16.Parse (n1) > Int16.Parse (n2))
        {
            return n2;
        }
        else
        {
            return n1;
        }
    }
}