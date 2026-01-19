public class Ques5
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the expression eg(a + b): ");
        string? input=Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error:InvalidExpression");
            return;
        }
        string[] parts=input.Split(" ");
        if (parts.Length != 3 )
        {
            System.Console.WriteLine("Error: InvalidExpression");
            return;
        }
        string op=parts[1];
        if(!int.TryParse(parts[0],out int a) || !int.TryParse(parts[2],out int b))
        {
            System.Console.WriteLine("Error: Invalid Number");
            return;
        }
        
        if(op=="+" || op=="-" || op=="*" || op=="/")
        {
            int result=0;
            switch (op)
        {
            case "+":
                System.Console.WriteLine($"Addition of {a} and {b} is {(result=a+b).ToString()}");
                break;
            case "-":
                System.Console.WriteLine($"Substracton of {a} and {b} is {(result=a-b).ToString()}");
                break;
            case "*":
                System.Console.WriteLine($"Multiplication of {a} and {b} is {(result=a*b).ToString()}");
                break;
            case "/":
                if (b != 0)
                {
                    System.Console.WriteLine($"Division of {a} and {b} is {(result=a/b).ToString()}");
                }
                else
                {
                    System.Console.WriteLine("Error: Divide By Zero");
                }
                break;
            }
        }
        else
        {
            System.Console.WriteLine("Error: Unknown Operator");
        }

    }
}
