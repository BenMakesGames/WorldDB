using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Countries;

public class IndexModel : PageModel
{
    private readonly CountryService _countryService;

    public IndexModel(CountryService countryService)
    {
        _countryService = countryService;
    }

    public List<Country> Countries { get; set; } = new();

    public void OnGet()
    {
        Countries = _countryService.GetAll();
    }
}
