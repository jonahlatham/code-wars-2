public class Program
{
    public static bool ProfitableGamble (double prob, int prize, double pay)
    {
        return prob * prize > pay;
    }
}