public class Program
{
    public static void Main()
    {
        Console.WriteLine("enter text = ");
        string text = Console.ReadLine();
        string result = IsPalindrome(text) ? text + " is Palindrome" : text + " is not Palindrome";
        Console.WriteLine(result);
    }

    public static bool IsPalindrome(string text)
    {
        bool result = true;
        int length = text.Length;
        for(int i = 0; i< length/2; i++)
        {
            if(text[i] != text[length-1-i])
            {
                result = false;
                return result;
            }
        } 
        return result;
    }
}