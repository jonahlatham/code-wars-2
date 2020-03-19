using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public List<int> filterArr (List<int> arr1, List<int> arr2, List<int> arr3)
    {
        return arr1.Where (e => arr2.Contains (e)).Where (e => arr3.Contains (e)).ToList();
    }
}