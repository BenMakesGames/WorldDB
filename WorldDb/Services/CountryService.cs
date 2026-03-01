using WorldDb.Models;

namespace WorldDb.Services;

public class CountryService
{
    private readonly List<Country> _countries = new();

    public List<Country> GetAll() => _countries;

    public Country? GetBySlug(string slug) =>
        _countries.FirstOrDefault(c => c.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
