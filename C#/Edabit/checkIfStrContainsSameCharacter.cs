using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public bool isIdentical (string str)
    {
        return str.Distinct ().Count () == 1;
    }
}