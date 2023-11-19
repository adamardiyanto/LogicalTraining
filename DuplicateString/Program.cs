public class Progam
{
    public static void Main()
    {
        System.Console.WriteLine("enter text = ");
        string? input = Console.ReadLine();
        string result = string.Empty;
        for(int i=0; i< input.Length; i++)
        {
            if(!result.Contains(input[i]))
            {
                result += input[i];
            }
        }

        System.Console.WriteLine(result);

    }
}