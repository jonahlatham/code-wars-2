public class Kata
{
    public static string CreatePhoneNumber (int[] numbers)
    {
        return String.Format ("{0:(###) ###-####}", Int32.Parse (string.Join ("", numbers)));
    }
}