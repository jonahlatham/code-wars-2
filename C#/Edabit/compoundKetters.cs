public class Program
{
    public static string Accum (string str)
    {
        string answer = "";
        for (int i = 0; i < str.Length; i++)
        {
            answer = answer + char.ToUpper (str[i]) + new string (char.ToLower (str[i]), i) + '-';
        }

        return answer.Substring (0, answer.Length - 1);
    }
}