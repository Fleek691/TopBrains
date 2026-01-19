using System.Text.Json;

public class Ques4
{
    public static void Main(string[] args)
    {
        string[] items = { "Avsihek:78", "Anita:90", "Rahul:45", "Bob:90" };
        int minScore = 70;

        string json = Filter(items, minScore);
        Console.WriteLine(json);
    }
    public static string Filter(string[] student,int minScore)
    {
        List<Student> students=new List<Student>();
        System.Console.WriteLine("Enter number of students: ");
        
        foreach(var item in student)
        {
            string[] parts=item.Split(":");
            string name=parts[0];
            int score=int.Parse(parts[1]);
            students.Add(new Student{Name=name,Score=score});
            
        }
        var result=(from s in students where s.Score>=minScore orderby s.Score descending ,s.Name ascending select s).ToList();
        string json = JsonSerializer.Serialize(result);
        return json;
    }
    
}
public record Student
{
    public string? Name{get;set;}
    public int Score{get;set;}
}
