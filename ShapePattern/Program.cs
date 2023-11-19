public class Progam
{
    public static void Main()
    {
        Console.WriteLine("Enter Number : ");
        int input;
        int.TryParse(Console.ReadLine(),out input);
        LeftTriangle(input);
        RightTriangle(input);
        LeftTriangleHollow(input);
        RightTriangleHollow(input);

    }
    public static void LeftTriangle(int input)
    {
        for(int i =0; i < input; i++)
        {
            for (int j = 0; j <=i; j++ )
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void RightTriangle(int input)
    {
        for(int i =0; i < input; i++)
        {
            for (int k = input-i; k > 1; k-- )
            {
                Console.Write(" ");
            }
            for (int j = 0; j <=i; j++ )
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void LeftTriangleHollow(int input)
    {
        for(int i =0; i < input; i++)
        {
            for (int j = 0; j <= i; j++ )
            {
                if(j == 0 || i == input -1 || j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void RightTriangleHollow(int input)
    {
        for(int i =0; i < input; i++)
        {
            for (int k = input-i; k > 1; k-- )
            {
                Console.Write(" ");
            }
            for (int j = 0; j <=i; j++ )
            {
                if(j == 0 || i == input-1 || i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    
}