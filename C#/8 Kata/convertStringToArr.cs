namespace Solution
{
    using System.Linq;
    using System;

    public class Solution
    {
        public static string[] StringToArray (string str)
        {
            return str.Split (" ").ToArray ();
        }
    }
}