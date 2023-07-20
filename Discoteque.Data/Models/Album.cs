namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>
{
    public string Name { get; set; } = "";
    public int Year { get; set; }
    public Genres Genre { get; set; } = Genres.Unknown;
}

public enum Genres
{
    Rock,
    Metal,
    Salsa,
    Urban,
    Folk,
    Indie,
    Techno,
    Unknown
}