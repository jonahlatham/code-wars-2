using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static double Calculator (double a, double b, char op)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;
            default:
                throw new System.ArgumentException ();
        }
    }
}