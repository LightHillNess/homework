using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
 
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

 
        string input = "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan Ivanov";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
