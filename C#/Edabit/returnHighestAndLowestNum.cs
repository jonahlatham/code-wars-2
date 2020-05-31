using System.Linq;

public class Program
{
    public static string HighLow (string str)
    {
        var ints = str.Split (' ').Select (int.Parse);
        return $"{ints.Max()} {ints.Min()}";
    }
}