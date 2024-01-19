using System.ComponentModel;

int numberTeams = int.Parse(Console.ReadLine());
List<string> teams = new List<string>();
for (int i = 0; i < numberTeams; i++)
{
    teams = Console.ReadLine().Split("-").ToList();
    string teamName = teams[0];
    if (teams.Contains(teams[1]))
    {
        Console.WriteLine($"Team {teams[1]} has been created by {teamName}!");
    }
    else 
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    
}