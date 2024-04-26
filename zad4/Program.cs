using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> furnitureList = new List<string>();
        double totalCost = 0.0;

        string pattern = @">>([a-zA-Z]+)<<(\d+(?:.\d+)?)!(\d+)";

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Purchase")
                break;

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string furniture = match.Groups[1].Value;
                double price = double.Parse(match.Groups[2].Value);
                int quantity = int.Parse(match.Groups[3].Value);

                furnitureList.Add(furniture);

                totalCost += price * quantity;
            }
        }

        Console.WriteLine("Bought furniture:");
        if (furnitureList.Count > 0)
        {
            foreach (string furniture in furnitureList)
            {
                Console.WriteLine(furniture);
            }
        }

        Console.WriteLine($"Total money spent: {totalCost:F2}");
    }
}