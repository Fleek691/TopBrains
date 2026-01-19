// Class representing the multiplication table functionality
public class Ques2
{
    // Method to perform multiplication based on user input
    public static void Multiplication()
    {
        // Prompt user for the first number
        System.Console.WriteLine("Enter Number: ");
        int a=int.Parse(Console.ReadLine()!);
        // Prompt user for the limit of multiplication
        System.Console.WriteLine("Enter the Number Upto where you want to Multiply: ");
        int b=int.Parse(Console.ReadLine()!);
        // Get the multiplication results
        var result=Result(a,b);
        // Display the results
        foreach(var item in result)
        {
            System.Console.Write(item+" ");
        }

    }
    // Method to calculate multiplication results
    public static int[]Result(int a,int b)
    {
        if(b<0)return new int[]{};//condition for when the upto number is negative
        int[]res=new int[b];
        // Loop to calculate multiplication
        for(int i = 1; i <= b; i++)
        {
            res[i-1]=a*i;
        } 
        return res;
    }
    // Main method - entry point of the program
    public static void Main(string[] args)
    {
        Multiplication();
    }
}