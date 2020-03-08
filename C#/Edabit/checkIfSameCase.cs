public class Program
{
    public static bool SameCase (string str)
    {
        return str == str.ToUpper () || str == str.ToLower ();
    }
}