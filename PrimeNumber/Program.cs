public class Program
{
    public static void Main()
    {
        Console.WriteLine("enter number = ");
        int number;
        int.TryParse(Console.ReadLine(),out number);
        string result = CheckPrime(number) ? "Number is Prime" : "Number is not Prime";
        Console.WriteLine(result);
    }

    public static bool CheckPrime(int number)
    {
        bool isPrime = true;

        for(int i = 2; i <= number /2; i++)
        {
            if(number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
}