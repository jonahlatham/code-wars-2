using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    { 
      return n.ToString().Reverse().Select(x => Convert.ToInt64(x.ToString())).ToArray();
    }
  }
}