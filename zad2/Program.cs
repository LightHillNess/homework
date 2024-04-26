using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Входни данни - низ, в който ще търсим телефонни номера
        string input = Console.ReadLine();

        // Регулярен израз за телефонни номера от София
        string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

        // Търсене на съвпадения
        MatchCollection matches = Regex.Matches(input, regex);

        // Отпечатване на валидните телефонни номера
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}