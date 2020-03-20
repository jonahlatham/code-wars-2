using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public string Reverse (string str)
    {
        return str.Split ("").Reverse ().Join ("");
    }
}
