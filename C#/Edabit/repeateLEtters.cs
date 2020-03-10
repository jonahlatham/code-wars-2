public class Program
{
    public static string DoubleChar (string str)
    {
        char[] words = str.ToCharArray ();
        List<string> abc = new List<string> ();
        foreach (var i in words)
        {
            abc.Add (i.ToString () + i.ToString ());
        }
        return String.Join ("", abc);
    }
}