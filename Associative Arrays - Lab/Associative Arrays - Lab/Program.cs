int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

SortedDictionary<int,int> sortNumber = new SortedDictionary<int,int>();

for (int i = 0; i < numbers.Length; i++)
{
    if (!sortNumber.ContainsKey(numbers[i]))
    {
        sortNumber[numbers[i]]=1;
    }
    else
    {
        sortNumber[numbers[i]] += 1;

    }
}

foreach (KeyValuePair<int,int> kvp in sortNumber)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}