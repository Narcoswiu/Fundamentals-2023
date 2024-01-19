using System.Text;
using System.Xml;

string text = Console.ReadLine();
string firstText;
string[] oddText = new string[] { };
while ((firstText = Console.ReadLine()) != "Done")
{
    string[] arguments = firstText.Split(" ").ToArray();
    if (arguments[0] == "TakeOdd")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < text.Length; i += 2)
        {
            if (i % 2 != 0 || i == 0)
            {
                sb.Append(text[i]);
            }
        }
        text = sb.ToString();
        Console.WriteLine(text);
    }
    else if (arguments[0] == "Cut")
    {
        int index = int.Parse(arguments[1]);
        int lenght = int.Parse(arguments[2]);
        text = text.Remove(index, lenght);
        Console.WriteLine(text);

    }
    else if (arguments[0] == "Substitute")
    {
        string sign = arguments[1];
        string replaceSign = arguments[2];
        if (text.Contains(sign))
        {
            text = text.Replace(sign, replaceSign);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
}

Console.WriteLine($"Your password is: {text}");