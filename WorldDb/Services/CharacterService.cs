using WorldDb.Models;

namespace WorldDb.Services;

public class CharacterService
{
    private readonly List<Character> _characters = new();

    public List<Character> GetAll() => _characters;

    public Character? GetBySlug(string slug) =>
        _characters.FirstOrDefault(c => c.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
