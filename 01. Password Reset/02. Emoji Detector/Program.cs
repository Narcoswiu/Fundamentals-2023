using System.Text.RegularExpressions;
string coolThresholdPattern = @"\d"; 
string pattern = @"(?<start>\:{2}|\*{2})(?<length>[A-Z][a-z]{2,})\1";
List<string> coolEmojies = new List<string>();
string input = Console.ReadLine();
ulong coolThreshold = 1;

foreach (Match match in Regex.Matches(input, coolThresholdPattern))
{
    coolThreshold *= ulong.Parse(match.Value);
}

ulong emojiCounter = 0;
foreach (Match match in Regex.Matches(input, pattern))
{
    string emojiStr = match.Groups["Emoji"].Value;
    ulong totalEmojiSum = 0;
    emojiCounter++;
    foreach (char character in emojiStr)
    {
        totalEmojiSum += character;
    }

    if (totalEmojiSum >= coolThreshold)
    {
        coolEmojies.Add(match.Value);
    }
}
Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{emojiCounter} emojis found in the text. The cool ones are:");
coolEmojies.ForEach(emoji => Console.WriteLine(emoji));