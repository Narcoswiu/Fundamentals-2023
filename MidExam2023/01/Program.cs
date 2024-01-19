double needExperience = double.Parse(Console.ReadLine());
int countOFBattles = int.Parse(Console.ReadLine());
int count = 0;
double neededExperience = 0;
for (int i = 1; i <= countOFBattles; i++)
{
    double experiencePerBattle = double.Parse(Console.ReadLine());
    if (i % 3 == 0)
    {
        neededExperience += experiencePerBattle + (experiencePerBattle * 0.15);
        count++;
    }
    else if (i % 5 == 0)
    {
        neededExperience += experiencePerBattle - (experiencePerBattle * 0.10);
        count++;
    }
    else if (i % 15 == 0)
    {
        neededExperience += experiencePerBattle + (experiencePerBattle * 0.05);
        count++;
    }
    else
    {
        neededExperience += experiencePerBattle;
        count++;
    }

    if (neededExperience >= needExperience)
    {
        break;
    }
    
}

if (neededExperience >= needExperience)
{
    Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
}
else
{
    Console.WriteLine($"Player was not able to collect the needed experience, {needExperience-neededExperience:F2} more needed.");
}