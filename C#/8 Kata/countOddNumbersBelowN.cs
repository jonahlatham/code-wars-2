using System;
public static class Kata
{
    public static ulong OddCount (ulong n)
    {

        int i = 0;
        var stuff = new List<int> ();
        for (i = 0; i <= Convert.ToInt32 (n); i++)
        {
            if (i % 2 != 0)
            {
                stuff.Add (i);
            }
        }
        return Convert.ToUInt32 (stuff.Sum ());
    }
}