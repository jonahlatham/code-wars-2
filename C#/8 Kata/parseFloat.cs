public class Kata
{
    public static double? ParseF (object s = null)
    {
        return double.TryParse (s?.ToString (), out var result) ? result : (double?) null;
    }
}