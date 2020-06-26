using System;

public class Kata
{
  public static int CalculateTip (double amount, string rating)
  {
    rating = rating.ToLower ();
    switch (rating)
    {
      case "terrible":
        return 0;
      case "poor":
        return (int) Math.Ceiling (amount / 100 * 5);
      case "good":
        return (int) Math.Ceiling (amount / 100 * 10);
      case "great":
        return (int) Math.Ceiling (amount / 100 * 15);
      case "excellent":
        return (int) Math.Ceiling (amount / 100 * 20);
    }
    return -1;
  }
}