 using System.Collections.Generic;
 using System.Linq;
 using System;

 public class Program
 {
     public static int[] FilterArray (object[] arr)
     {
         return arr.OfType<int> ().ToArray ();
     }
 }