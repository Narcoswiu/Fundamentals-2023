﻿int count = int.Parse(Console.ReadLine());
Ad ad = new Ad();
ad.Phrases = new[]
{
        "Excellent product.",
        "Such a great product.",
        "I always use that product.",
        "Best product of its category.",
        "Exceptional product.",
        "I can't live without this product."
};

ad.Events = new[]
{
    "Now I feel good.",
    "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.",
    "I feel great!"
};

ad.Authors = new[]
{
    "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
};

ad.Cities = new[]
{
    "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
};

for (int i = 0; i < count; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(ad.Phrases.Length);
    string phrase = ad.Phrases[randomIndex];

    randomIndex = random.Next(ad.Events.Length);
    string e = ad.Events[randomIndex];

    randomIndex = random.Next(ad.Cities.Length);
    string city = ad.Cities[randomIndex];

    randomIndex = random.Next(ad.Authors.Length);
    string author = ad.Authors[randomIndex];

    Console.WriteLine($"{phrase} {e} {author} - {city}.");
}
class Ad
{
    public string[] Phrases { get; set; }
    public string[] Events { get; set; }
    public string[] Authors { get; set; }
    public string[] Cities { get; set; }

}