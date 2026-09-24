namespace Teamappen;

static class Team
{
    static List<string> members = new List<string>
    {
        "Jessica",
        "Stephanie",
        "Sania the one and only",
        // Lägg till ert namn här, ett per rad
    };

    public static void PrintMembers()
    {
        Console.WriteLine("Vi som gjort appen (i ordning av bästa personen):");
        foreach (string member in members)
        {
            Console.WriteLine($"- {member}");
        }
    }
}
