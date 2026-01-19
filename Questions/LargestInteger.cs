public class Ques6
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the three numbers: ");
        int a=int.Parse(Console.ReadLine()!);
        int b=int.Parse(Console.ReadLine()!);
        int c=int.Parse(Console.ReadLine()!);
        if(a>=b && a >=c)
        {
            System.Console.WriteLine(a);
        }else if(b>=a && b>=c)
        {
            System.Console.WriteLine(b);
        }
        else
        {
            System.Console.WriteLine(c);
        }
    }
}