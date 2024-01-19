
using System;

double energy = double.Parse(Console.ReadLine());
double winsCount = 0;
string command;
while ((command = Console.ReadLine()) != "End of battle")
{
    double energyDestroy = double.Parse(command);

    if (energy - energyDestroy >= 0)
    {
        winsCount++;
        energy -= energyDestroy;
    }
    else
    {
        Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");
        break;
    }

    if (winsCount % 3 == 0)
    {
        energy += winsCount;
    }

}

if (command== "End of battle")
{
    Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
}
