string firstText = Console.ReadLine();
string command;
while ((command = Console.ReadLine()) != "Abracadabra")
{
    string[] arguments = command.Split(" ").ToArray();
    string direction = arguments[0];
    if (direction == "Abjuration")
    {
        firstText = firstText.ToUpper();
        Console.WriteLine(firstText);
    }
    else if (direction == "Necromancy")
    {
        firstText = firstText.ToLower();
        Console.WriteLine(firstText);
    }
    else if (direction == "Illusion")
    {
        int index = int.Parse(arguments[1]);
        char letter = char.Parse(arguments[2]);
        char[] charArray = firstText.ToCharArray();
        if (index >= 0 && index < firstText.Length)
        {
            charArray[index] = letter;
            string updateString = new string(charArray);
            firstText = updateString;
            Console.WriteLine("Done!");
        }
        else
        {
            Console.WriteLine("The spell was too weak.");
        }
    }
    else if (direction == "Divination")
    {
        string firstSubstring = arguments[1];
        string secondSubstring = arguments[2];
        if (firstText.Contains(firstSubstring))
        {
            firstText = firstText.Replace(firstSubstring, secondSubstring);
            Console.WriteLine(firstText);
        }
    }
    else if (direction == "Alteration")
    {
        string substring = arguments[1];
        if (firstText.Contains(substring))
        {
            firstText = firstText.Replace(substring, "");
            Console.WriteLine(firstText);
        }
    }
    else
    {
        Console.WriteLine("The spell did not work!");
    }
}