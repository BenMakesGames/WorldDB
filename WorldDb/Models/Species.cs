namespace WorldDb.Models;

public class Species
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Classification { get; set; } = string.Empty;
    public string Habitat { get; set; } = string.Empty;
}
