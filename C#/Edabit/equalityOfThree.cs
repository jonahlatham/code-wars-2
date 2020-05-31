public class Program
{
    public static int Equal(int a, int b, int c)
    {
			return (a==b && b==c) ? 3 : (a!=b && b!= c && a!=c) ? 0 : 2; 
    }
}