// 1.cs
partial class Book
{
    public string name;
    public string author;
    public int year;
}

// 2.cs
partial class Book
{
    public Book(string name, string author, int year)
    {
        this.name = name;
        this.author = author;
        this.year = year;
    }
 
    public void GetInformation()
    {
        Console.WriteLine(" нига '{0}' (автор {1}) была издана в {2} году", name, author, year);
    }
}
