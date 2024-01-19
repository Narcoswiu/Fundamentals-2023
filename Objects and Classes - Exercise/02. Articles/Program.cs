
Article article = new Article();
int n =int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    
}



class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public void Edit(string newContent)
    {
        Content=newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        Title = newTitle;
    }
    public override string ToString()
    {
        return "{title} - {content}: {author}";
    }
}


