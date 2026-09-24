namespace Teamappen;

static class Quotes
{
    static List<string> quotes = new List<string>
    {
        "Commit early, commit often.",
        "Det fungerar på min dator.",
        "Strålande blå sol",
        "hej babes",
        "Roses are red, violets are blue, keep calm § and code on.",
        "Blå blå himmels blå",
    };

    public static string GetRandomQuotes()
    {
        Random random = new Random();
        return quotes[random.Next(quotes.Count)];
    }
}
