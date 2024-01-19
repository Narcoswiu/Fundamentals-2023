using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

int count = int.Parse(Console.ReadLine());

//string pattern = @"(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])\1";
string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$"; // No Backreference
Regex barcodeRegex = new Regex(pattern);
for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);

    if (match.Success)
    {
        string productGroup = "";

        for (int j = 0; j < match.Value.Length; i++)
        {
            if (char.IsDigit(match.Value[j]))
            {
                productGroup += match.Value[j];
            }
        }

        if (productGroup != "")
        {
            Console.WriteLine($"Product group: {productGroup}");
        }
        else
        {
            Console.WriteLine($"Product group: 00");
        }
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}