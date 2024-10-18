class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            ShowUsage();
            return;
        }
        Console.WriteLine($"Hello {args[0]}");
    }

    static void ShowUsage()
    {
        Console.WriteLine("Show Usage");
    }
}