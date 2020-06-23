using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace (string input)
        {
            return input.Replace (" ", String.Empty);
        }
    }
}