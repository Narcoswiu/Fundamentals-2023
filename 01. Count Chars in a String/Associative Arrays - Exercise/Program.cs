﻿string input = Console.ReadLine();
Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char character = input[i];
    if (character == ' ')
    {
        continue;
    }

    if (!charOccurrences.ContainsKey(character))
    {
        charOccurrences.Add(character, 0);
    }
    charOccurrences[character]++;
}

foreach (var occurrence in charOccurrences)
{
    char character = occurrence.Key;
    int  count = occurrence.Value;
    Console.WriteLine($"{character} -> {count}");
}
