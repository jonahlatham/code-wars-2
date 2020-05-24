using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static string[] IsFourLetters (string[] arr)
    {
        return arr.Where (e => e.Length == 4).ToArray ();
    }
}