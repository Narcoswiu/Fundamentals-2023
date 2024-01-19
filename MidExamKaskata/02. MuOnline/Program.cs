
List<string> dungeonsRooms = Console.ReadLine().Split("|").ToList();
int health = 100;
int bitcoins = 0;
int currHealth = 0;
int tempHealth = 0;
for (int i = 0; i < dungeonsRooms.Count; i++)
{
    string command = dungeonsRooms[i];
    string[] commandRooms = command.Split();
    string commands = commandRooms[0];
    int heal = int.Parse(commandRooms[1]);

    if (commands == "potion")
    {
        c
        if (health + heal <= 100)
        {
            Console.WriteLine($"You healed for {heal} hp.");
            Console.WriteLine($"Current health: {health + heal} hp.");
        }
        else if ()
        {
            continue;
        }

    }
    else if (commands == "chest")
    {
        bitcoins += heal;
        Console.WriteLine($"You found {heal} bitcoins.");
    }
    else
    {
        health -= heal;
        if (health <= 0)
        {
            Console.WriteLine($"You slayed {commands}.");
        }
        else
        {
            Console.WriteLine($"You died! Killed by {commands}.");
            Console.WriteLine($"Best room: {dungeonsRooms.Count - 1}");
        }
    }
}