using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string SubReddit (string link)
    {
        return link.Replace ("https://www.reddit.com/r/", "").Replace ("/", "");
    }
}