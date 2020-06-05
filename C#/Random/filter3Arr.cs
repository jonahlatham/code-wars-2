using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public List<int> filterArr (List<int> arr1, List<int> arr2, List<int> arr3)
    {
        return arr1.Where (e => arr2.Contains (e)).Where (e => arr3.Contains (e)).ToList ();
    }

    public int[] filterArr (int[] arr1, int[] arr2, int[] arr3)
    {
        return arr1.Where (e => arr2.Contains (e)).Where (x => arr3.Contains (x)).ToArray ();
    }
}