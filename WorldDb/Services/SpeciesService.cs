using WorldDb.Models;

namespace WorldDb.Services;

public class SpeciesService
{
    private readonly List<Species> _species = new()
    {
        new Species { Id = 1, Name = "Pvirla", Slug = "pvirla", Classification = "Mammal", Habitat = "Forest" },
    };

    public List<Species> GetAll() => _species;

    public Species? GetBySlug(string slug) =>
        _species.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
