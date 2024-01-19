int numberSongs = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();
for (int i = 0; i < numberSongs; i++)
{
    string[] songInfo = Console.ReadLine().Split("_");
    Song song = new Song();
    song.Name = songInfo[1]; 
    song.Time = songInfo[2];
    song.Type = songInfo[0];

    songs.Add(song);
}

string typeList = Console.ReadLine();
if (typeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in songs)
    {
        if (song.Type == typeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}
class Song
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

}
