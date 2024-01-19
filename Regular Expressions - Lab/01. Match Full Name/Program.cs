using System.Text.RegularExpressions;

string input =Console.ReadLine();
string pattern = @"\b([A-Z][a-z]\b+) ([A-Z][a-z]+)";
Regex regex= new Regex(pattern);
MatchCollection  matches = regex.Matches(input);
foreach (Match match in matches)
{
    Console.Write($"{match.Groups[0]} {match.Groups[1]}");
}