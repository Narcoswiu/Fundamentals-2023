
using System.ComponentModel;

string command;
List<Box> allProducts=new List<Box>();
double priceForBox = 0;
while ((command = Console.ReadLine()) != "end")
{
    string[] commands = command.Split();
    Box Box = new Box();
    Box.Item=new Item();

    Box.SerialNumber = commands[0];
    Box.Item.Name = commands[1];
    Box.ItemQuanity = int.Parse(commands[2]);
    Box.PriceForBox = double.Parse(commands[3]);
    Box.Item.Price = Box.ItemQuanity * Box.PriceForBox;
    allProducts.Add(Box);
}
List<Box> sortedBox = allProducts.OrderByDescending(allProducts => allProducts.Item.Price).ToList();
foreach (Box Box in sortedBox)
{
    Console.WriteLine($"{Box.SerialNumber}");
    Console.WriteLine($"-- {Box.Item.Name} - ${Box.PriceForBox:f2}: {Box.ItemQuanity}");
    Console.WriteLine($"-- ${Box.Item.Price:f2}");
}


class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuanity { get; set; }
    public double PriceForBox { get; set; }
}