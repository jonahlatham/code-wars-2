using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public List<int> arrAddTen (List<int> x)
    {
        return x.Select (e => e + 10).ToList ();
    }
}