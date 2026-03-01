using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Countries;

public class DetailsModel : PageModel
{
    private readonly CountryService _countryService;

    public DetailsModel(CountryService countryService)
    {
        _countryService = countryService;
    }

    public Country? Country { get; set; }

    public IActionResult OnGet(string slug)
    {
        Country = _countryService.GetBySlug(slug);
        if (Country is null)
            return NotFound();
        return Page();
    }
}
