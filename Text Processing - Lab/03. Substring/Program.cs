string removeWord = Console.ReadLine();
string word=Console.ReadLine();


while (word.Contains(removeWord))
{
    int startIndex=word.IndexOf(removeWord);
    word = word.Remove(startIndex,removeWord.Length);
}

Console.WriteLine(word);