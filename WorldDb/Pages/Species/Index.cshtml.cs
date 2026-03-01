using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Species;

public class IndexModel : PageModel
{
    private readonly SpeciesService _speciesService;

    public IndexModel(SpeciesService speciesService)
    {
        _speciesService = speciesService;
    }

    public List<Models.Species> AllSpecies { get; set; } = new();

    public void OnGet()
    {
        AllSpecies = _speciesService.GetAll();
    }
}
