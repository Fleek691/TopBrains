public class Ques1
{
    // Entry point of the program
    public static void Main()
    {
        CalculateLuckyNumber();
    }
    // Calculates and counts lucky numbers in a given range
    public static void CalculateLuckyNumber()
    {
        // Get the starting number from user
        System.Console.WriteLine("Enter First number: ");
        int m=int.Parse(Console.ReadLine());
        // Get the ending number from user
        System.Console.WriteLine("Enter Second Digit: ");
        int n=int.Parse(Console.ReadLine());
        // Counter for lucky numbers
        int count=0;
        // Validate that m is not greater than n
        if (m > n)
        {
            System.Console.WriteLine("First Number Cannot be greater than the Second Number");
        }
        else
        {
            // Loop through all numbers in range
            for(int i = m; i < n+1; i++)
        {
            // Check if number is not prime
            if (!isPrime(i))
            {
                // Calculate sum of digits of the number
                int sum1=0;
                string a=i.ToString();
                // Sum each digit of the number
                for(int j = 0; j < a.Length; j++)
                {
                    sum1+=int.Parse(a[j].ToString());
                }
                // Calculate square of the number
                int squarredNumm=i*i;
                // Calculate sum of digits of the squared number
                int sum2=0;
                string b=squarredNumm.ToString();
                for(int j = 0; j < b.Length; j++)
                {
                    sum2+=int.Parse(b[j].ToString());
                }
                // Check if square of digit sum equals squared number's digit sum
                if ((sum1*sum1) == sum2)
                {
                    // Increment count if number is lucky
                    count++;
                }
            }
        }
        System.Console.WriteLine("Total Lucky Numbers: "+count);
        }
        
    }
    // Checks if a number is prime
    public static bool isPrime(int n)
    {
        bool res=true;
        // Numbers less than or equal to 1 are not prime
        if (n <= 1)
        {
            return res=false;
        }
        else
        {
            // Check divisibility up to square root of n
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                // If divisible, number is not prime
                if (n % i == 0)
                {
                    return res=false;
                }
                
            }
        }
        return res;
    }
}