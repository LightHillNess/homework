using System;
using System.Text.RegularExpressions;


    string input = Console.ReadLine();

    
    string pattern = @"(\d{2})([-./])([A-Z][a-z]{2})\2(\d{4})";


    Regex regex = new Regex(pattern);


    MatchCollection matches = regex.Matches(input);

    foreach (Match match in matches)
    {
        if (match.Success)
        {
            Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[4].Value}");
        }
    }
    //neznam kakvo e chatgpt