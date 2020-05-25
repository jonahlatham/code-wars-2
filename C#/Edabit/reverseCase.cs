public class Program
{
    public static string ReverseCase (string str)
    {
        return string.Concat (str.Select (x => char.IsUpper (x) ? char.ToLower (x) : char.ToUpper (x)));
    }
}