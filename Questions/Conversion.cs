public class Ques9
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter heigh in foot: ");
        int foot=int.Parse(Console.ReadLine()!);
        double cm=foot*30.48;
        double res=Math.Round(cm,2,MidpointRounding.AwayFromZero);
        System.Console.WriteLine(res);
    }
}