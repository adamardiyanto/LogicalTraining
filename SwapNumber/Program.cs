public class Program
{
    public static void Main()
    {
        int number1 = 12;
        int number2 = 31;

        Console.WriteLine($"Number before swap number 1 = {number1} and number 2 = {number2}");

        //Swap number without using temp var
        number1 = number1 * number2;
        number2 = number1 / number2;
        number1 = number1 / number2;

        Console.WriteLine($"Number after swap number 1 = {number1} and number 2 = {number2}");
        

    }

}