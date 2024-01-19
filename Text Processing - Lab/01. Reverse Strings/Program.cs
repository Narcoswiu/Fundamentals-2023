string[] input= Console.ReadLine().Split().ToArray();
string result = string.Empty;
foreach (var word in input)
{
    int currentWordLenght = word.Length;
    
    for (int i = 0; i < currentWordLenght; i++)
    {
        result += word;
    }
}
Console.Write(result);