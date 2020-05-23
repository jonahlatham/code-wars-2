using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static bool hurdleJump (int[] hurdles, int jumpHeight)
    {
        return jumpHeight >= (hurdles.Count () > 0 ? hurdles.Max () : 0);
    }
}