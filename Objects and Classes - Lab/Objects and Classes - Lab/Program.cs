string[] words = Console.ReadLine().Split().ToArray();

for (int i = 0; i < words.Length; i++)
{
    Random randomText = new Random();
    int randomIndex = randomText.Next(0, words.Length);

    string curentWord = words[i];
    string wordToSwap = words[randomIndex];

    words[i] = wordToSwap;
    words[randomIndex] = curentWord;

}

Console.WriteLine(string.Join(Environment.NewLine, words));