public class Program
{
    public static string MissingAngle (int a, int b) =>
        (a + b == 90) ? "right" : (a + b > 90) ? "acute" : "obtuse";
}