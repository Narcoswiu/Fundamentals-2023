List<string> shelf =
                Console.ReadLine()
                .Split('@',StringSplitOptions.RemoveEmptyEntries)
                .ToList();
string command = Console.ReadLine();
while (command != "Done")
{
    string[] commandInfo = command.Split(" | ");
    if (commandInfo[0] == "Add Book")
    {
        string firstBook = commandInfo[1];
        if (!shelf.Contains(firstBook))
        {
            shelf.Insert(0, firstBook);
        }
        else
        {
            continue;
        }
    }
    else if (commandInfo[0] == "Take Book")
    {
        string secondBook = commandInfo[1];
        if (shelf.Contains(secondBook))
        {
            shelf.Remove(secondBook);
        }
        else
        {
            continue;
        }
    }
    else if (commandInfo[0] == "Swap Books")
    {
        string thirdBook = commandInfo[1];
        string fourthBook = commandInfo[2];
        string copy = thirdBook;
        if (shelf.Contains(thirdBook) && shelf.Contains(fourthBook))
        {
            int firstIndex = shelf.IndexOf(thirdBook);
            int secondIndex = shelf.IndexOf(fourthBook);
            shelf[firstIndex] = fourthBook;
            shelf[secondIndex] = copy;
        }
        else
        {
            continue;
        }
    }
    else if (commandInfo[0] == "Insert Book")
    {
        string fifthBook = commandInfo[1];
        if (!shelf.Contains(fifthBook))
        {
            shelf.Add(fifthBook);
        }
        else
        {
            continue;
        }
    }
    else if (commandInfo[0] == "Check Book")
    {
        int index = int.Parse(commandInfo[1]);
        if (index >= 0 && index < shelf.Count)
        {
            Console.WriteLine(shelf[index]);
        }
        else
        {
            continue;
        }
    }

    command = Console.ReadLine();
}
Console.Write(string.Join(", ", shelf));