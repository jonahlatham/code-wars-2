using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static bool hurdleJump (int[] hurdles, int jumpHeight)
    {
        Array.Sort (hurdles);
        if (hurdles.Length - 1 > jumpHeight)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}