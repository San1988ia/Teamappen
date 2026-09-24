namespace Teamappen;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("De tre muskutörerna");
        Console.WriteLine("Tjolahopp!");
        Console.WriteLine("hej babe");
        Console.WriteLine();

        Team.PrintMembers();
        Console.WriteLine();

        Console.WriteLine($"Dagens citat: {Quotes.GetQuote()}");
    }
}

