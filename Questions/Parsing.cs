public class Ques7
{
    public static int SumValidIntegers(string[] tokens)
    {
        int sum = 0;

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    public static void Main()
    {
        string[] tokens = { "10", "20", "abc", "999999999999", "-5", "3.5" };

        int result = SumValidIntegers(tokens);
        Console.WriteLine(result); 
    }
}
