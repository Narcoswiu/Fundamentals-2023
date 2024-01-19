string[] vehicle=Console.ReadLine().Split(">>",StringSplitOptions.RemoveEmptyEntries).ToArray();

   double initialTax = 0;
for (int i = 0; i < vehicle.Length; i++)
{
    string[] perVehicle = vehicle[i].Split(" ");

    if (perVehicle[0] == "family")
    {
        initialTax = 50;
        initialTax -= double.Parse(perVehicle[1]) * 5;
        if (double.Parse(perVehicle[2]) % 3000 ==0)
        {
            initialTax += 12;
        }
        Console.WriteLine($"A {perVehicle[0]} car will pay {initialTax:F2} euros in taxes.");
    }
    else if (perVehicle[0] == "heavyDuty")
    {
        initialTax = 80;
        initialTax -= double.Parse(perVehicle[1]) * 8;
        if (double.Parse(perVehicle[2]) % 9000 == 0)
        {
            initialTax += 14;
        }
        Console.WriteLine($"A {perVehicle[0]} car will pay {initialTax:F2} euros in taxes.");
    }
    else if (perVehicle[0] == "sports")
    {
        initialTax = 100;
        initialTax -= double.Parse(perVehicle[1]) * 9;
        if (double.Parse(perVehicle[2]) % 2000 == 0)
        {
            initialTax += 18;
        }
        Console.WriteLine($"A {perVehicle[0]} car will pay {initialTax:F2} euros in taxes.");
    }
    else
    {
        Console.WriteLine("Invalid car type.");
    }

}

Console.WriteLine($"The National Revenue Agency will collect {initialTax:F2} euros in taxes.");
