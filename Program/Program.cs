namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Введите своё имя:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Привет,{name}");
    }
}
