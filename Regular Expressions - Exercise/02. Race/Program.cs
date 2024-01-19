using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

List<string> participantsNames = Console.ReadLine().Split(", ").ToList();
List<Participant> participants = new List<Participant>();

foreach (string name in participantsNames)
{
    Participant participant = new Participant(name);
    participants.Add(participant);
}

string input;
while ((input = Console.ReadLine()) != "end of race")
{
    StringBuilder nameBuilder = new StringBuilder();
    string lettersPattern = @"[A-Za-z]";
    string digitsPattern = @"\d";
    foreach (Match match in Regex.Matches(input, lettersPattern))
    {
        nameBuilder.Append(match.Value);
    }
    string participantsName = nameBuilder.ToString();
    uint distance = 0;
    foreach (Match match in Regex.Matches(input, digitsPattern))
    {
        distance += uint.Parse(match.Value);
    }
    Participant foundParticipant = participants.FirstOrDefault(p => p.Name == participantsName);
    if (foundParticipant != null)
    {
        foundParticipant.Distance += distance;
    }
}

List<Participant> FirstThreeParticipants =
    participants
        .OrderByDescending(p => p.Distance)
        .Take(3)
        .ToList();
Console.WriteLine($"1st place: {FirstThreeParticipants[0].Name}");
Console.WriteLine($"2nd place: {FirstThreeParticipants[1].Name}");
Console.WriteLine($"3rd place: {FirstThreeParticipants[2].Name}");

class Participant
{
    public Participant(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public uint Distance { get; set; }
}