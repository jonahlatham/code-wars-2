public class Program
{
    public static bool isPrime (int x)
    {
        int i = 2;
        while (i++ <= x && x % i != 0);
        return i == x;
    }
}