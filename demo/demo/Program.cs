using System;
using System.Collections.Generic;
using System.Linq;
Dictionary<string, Commands> users = new Dictionary<string, Commands>();
string input;
while ((input = Console.ReadLine()) != "Log out")
{
    string[] arguments = input.Split(": ").ToArray();
    switch (arguments[0])
    {
        case "New follower":
            {
                if (!users.ContainsKey(arguments[1]))
                {
                    Commands user = new Commands();
                    user.Name = arguments[1];
                    user.Comment = 0;
                    user.Like = 0;
                    users.Add(arguments[1], user);
                }

                break;
            }

        case "Like":
            if (!users.ContainsKey(arguments[1]))
            {
                users.Add(arguments[1], new Commands());
                users[arguments[1]].Comment = 0;
                users[arguments[1]].Like += int.Parse(arguments[2]);

            }
            else
            {
                users[arguments[1]].Like += int.Parse(arguments[2]);
            }
            break;
        case "Comment":
            if (!users.ContainsKey(arguments[1]))
            {
                users.Add(arguments[1], new Commands());
                users[arguments[1]].Comment++;

            }
            else
            {
                users[arguments[1]].Comment++;
            }
            break;
        case "Blocked":
            if (!users.ContainsKey(arguments[1]))
            {
                Console.WriteLine($"{arguments[1]} doesn't exist.");
            }
            else
            {
                users.Remove(arguments[1]);
            }
            break;
    }

    
}

Dictionary<string, int> renameDict = new Dictionary<string, int>();

foreach (var user in users)
{
    int all = user.Value.Comment + user.Value.Like;
    renameDict.Add(user.Key, all);
}

Console.WriteLine($"{renameDict.Count} followers");
foreach (var userInfo in renameDict)
{
    Console.WriteLine($"{userInfo.Key}: {userInfo.Value}");
}
class Commands
{
    public int Like = 0;
    public string Name;
    public int Comment = 0;
}