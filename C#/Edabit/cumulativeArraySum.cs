public class Program
{
    public static double[] CumulativeSum (double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] + arr[i - 1];
        }
        return arr;
    }
}