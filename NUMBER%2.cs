public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsEven(4));
        Console.WriteLine(IsEven(7));
        Console.WriteLine(IsEven(0));
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
