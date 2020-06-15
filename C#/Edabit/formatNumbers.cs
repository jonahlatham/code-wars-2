public class Program
{
    public static string FormatNum (int num)
    {
        return num.ToString ("N0"); //Zero not O //N add comma where needed
    }
    public static string FormatPercent (double num)
    {
        return num.ToString ("P0"); //Zero not O //P makes it a %
    }
    public static string FormatCurrency (double num)
    {
        return num.ToString ("C"); //Adding 0 would remove the decimals at end
    }
}