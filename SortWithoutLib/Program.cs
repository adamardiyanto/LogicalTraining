public class Program
{
    public static void Main()
    {
        int[] array = new int[] {3,4,2,7,5,1,6,8};
        foreach(var x in array)
        {
            System.Console.Write(x);
        }
        int temp = 0;
        for(int i = 0; i <= array.Length; i++)
        {
            for(int j = i+1; j<array.Length; j++)
            {
                if (array[i]< array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.ReadLine();
        foreach(var x in array)
        {
            System.Console.Write(x);
        }
    }
}