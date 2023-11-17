public class Program
{
    public static void Main()
    {
        Console.WriteLine("enter text = ");
        string text = Console.ReadLine();
        string reverse = string.Empty;
        for(int i=text.Length-1; i >= 0; i--)
        {
            reverse += text[i];
        }
        System.Console.WriteLine(reverse);
    }
}