// Demonstrates swapping using ref and out parameters
public class Ques3
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter First Number: ");
        int first=int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Enter Second Number: ");
        int second=int.Parse(Console.ReadLine()!);
        // Swap using ref
        refSwapping(ref first,ref second);
        System.Console.WriteLine($"Using ref First number becomes: {first} and Second number becomes: {second}");
        // Swap using out
        outSwapping(first, second, out first, out second);
        System.Console.WriteLine($"using out First number becomes: {first} and Second number becomes: {second}");

    }
    // Swaps using arithmetic without temp variable
    public static void refSwapping(ref int FIrstNumber,ref int SecondNumber)
    {
        FIrstNumber=FIrstNumber+SecondNumber;
        SecondNumber=FIrstNumber-SecondNumber;
        FIrstNumber=FIrstNumber-SecondNumber;
        System.Console.WriteLine();
    }
    // Swaps by direct assignment
    public static void outSwapping(int x, int y, out int a, out int b)
    {
        a = y;  
        b = x;
    }

}