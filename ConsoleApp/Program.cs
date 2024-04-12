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

        var max = Max(numbers);
        Console.WriteLine($"MAX= {max}");
    }

    private static int Avg(int[] arr)
    {
        var sum = 0;
        var size = arr.Length;
        foreach (var n in arr)
        {
            sum += n;
        }

        return sum / size;
    }

    private static int Max(int[] arr)
    {
        var max = 0;
        foreach (int number in arr)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }
}