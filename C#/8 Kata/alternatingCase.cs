using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class StringExt
    {
        public static string ToAlternatingCase (this string s)
        {
            return s.Select ((e, i) =>
            {
                if (e == e.ToUpper ())
                {
                    return e.ToLower ();
                }
                else
                {
                    return e.ToUpper ();
                }
            }).ToString ();
        }
    }
}