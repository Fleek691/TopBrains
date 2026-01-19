using System;

public class Ques8
{
    public static string CleanProductName(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        // STEP 1: Remove duplicate consecutive characters
        string noDuplicates = "";
        noDuplicates += input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
                noDuplicates += input[i];
        }

        // STEP 2: Remove extra spaces
        string cleanedSpaces = string.Join(" ",
            noDuplicates.Split(' ', StringSplitOptions.RemoveEmptyEntries));

        // STEP 3: Convert to Title Case
        string[] words = cleanedSpaces.ToLower().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
        }

        return string.Join(" ", words);
    }

    // Example
    public static void Main()
    {
        string input = "llappptop   bag";
        Console.WriteLine(CleanProductName(input));  // Laptop Bag
    }
}
