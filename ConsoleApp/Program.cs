class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name}! Enter your lastname:");
        String lastName = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name} {lastName}!");
    }
}