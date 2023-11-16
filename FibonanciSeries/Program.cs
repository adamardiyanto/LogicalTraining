public class Program
{
    public static void Main()
    {
        int start = 0, second = 1;
        int number = 10;
        Fibonanci(start, second, number);
    }

    public static void Fibonanci(int start, int second, int number)
    {
        int nextNum= 0;
        if(number == 1)
        {
            Console.WriteLine( start);
        }
        else if(number == 2)
        {
            Console.WriteLine( start + " " + second);
        }
        else
        {
            Console.Write( start + " " + second + " ");
            for( int i = 2; i < number; i++)
            {
                nextNum = start + second;
                Console.Write(nextNum + " ");
                start = second;
                second = nextNum;
            }            
        }
    }
}