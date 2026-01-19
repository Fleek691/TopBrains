public class Ques12
{
    public static void Main(string[] args)
    {
        List<int> id=new List<int>{ 1,4,5};
        Dictionary<int,int> a=new Dictionary<int, int>
        {
            {1,20000},
            {4,40000},
            {5,15000}
        };
        System.Console.WriteLine(GetSalary(id,a));
    }
    public static int GetSalary(List<int> id,Dictionary<int,int> dict)
    {
        int total=0;
        foreach(int i in id)
        {
            if (dict.ContainsKey(i))
            {
                total+=dict[i];
            }
        }
        return total;
    }
}
