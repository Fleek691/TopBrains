public class Ques13
{
    public static  void Main(string[] args)
    {
        System.Console.WriteLine("Enter radius: ");
        int r=int.Parse(Console.ReadLine()!);
        double p=Math.PI;
        double res=Math.Round(AreaCircle(r,p),2,MidpointRounding.AwayFromZero);
        System.Console.WriteLine(res);
        

    }
    public static double AreaCircle(int r, double pi)
    {
        double result=pi*(r*r);
        return result;        
    }
}