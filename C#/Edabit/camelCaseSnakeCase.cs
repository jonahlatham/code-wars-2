using System.Text.RegularExpressions;

public class Program 
{
    public static string ToSnakeCase(string str) 
    {
		    return Regex.Replace(str, "[A-Z]", "_$0").ToLower();
    }
    public static string ToCamelCase(string str) 
    {
			  return  Regex.Replace(str, "_[a-z]", delegate(Match m) {
				    return m.ToString().TrimStart('_').ToUpper();
			  });
    }
}