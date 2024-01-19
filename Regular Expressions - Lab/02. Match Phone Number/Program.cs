using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(\+359)(\s|\-)(2)\2(\d{3})\2(\d{4})\b";
var matches = Regex.Matches(input, pattern);
Console.WriteLine(string.Join(", ",matches));

