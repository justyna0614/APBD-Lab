class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name}! Enter your lastname:");
        String lastName = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name} {lastName}!");
        int[] numbers = { 2, 6, 4 };
        var avg = Avg(numbers);
        Console.WriteLine($"AVG= {avg}");
    }

    private static int Avg(int[] arr)
    {
        var sum = 0;
        var size = arr.Length;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum / size;
    }
}