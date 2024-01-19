string[] word = Console.ReadLine()
    .Split()
    .Where(w => w.Length % 2 == 0)
    .ToArray();

foreach (var words in word)
{
    Console.WriteLine(words);
}