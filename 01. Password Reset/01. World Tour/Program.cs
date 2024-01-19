string allStops = Console.ReadLine();
string command;
while ((command = Console.ReadLine()) != "Travel")
{
    string[] arguments = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
    if (arguments[0] == "Add Stop")
    {
        int index = int.Parse(arguments[1]);
        string newText = arguments[2];
        if (index >= 0 && index < allStops.Length)
        {
            allStops = allStops.Insert(index, newText);
            Console.WriteLine(allStops);
        }

    }
    else if (arguments[0] == "Remove Stop")
    {
        int startIndex = int.Parse(arguments[1]);
        int endIndex = int.Parse(arguments[2]);

        if ((startIndex >= 0 && startIndex < allStops.Length) && (endIndex >= 0 && endIndex < allStops.Length))
        {
            allStops = allStops.Remove(startIndex, endIndex - startIndex + 1);
            Console.WriteLine(allStops);
        }
    }
    else if (arguments[0] == "Switch")
    {
        string oldText = arguments[1];
        string newText = arguments[2];
        if (allStops.Contains(oldText))
        {
            allStops = allStops.Replace(oldText, newText);
            Console.WriteLine(allStops);
        }
        else
        {
            Console.WriteLine(allStops);
        }
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");