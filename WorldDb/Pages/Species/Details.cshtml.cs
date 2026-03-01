using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Species;

public class DetailsModel : PageModel
{
    private readonly SpeciesService _speciesService;

    public DetailsModel(SpeciesService speciesService)
    {
        _speciesService = speciesService;
    }

    public Models.Species? Species { get; set; }

    public IActionResult OnGet(string slug)
    {
        Species = _speciesService.GetBySlug(slug);
        if (Species is null)
            return NotFound();
        return Page();
    }
}
