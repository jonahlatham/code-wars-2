public class Program
{
    public static bool DoubleLetters (string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1]) { return true; }
        }
        return false;
    }
}