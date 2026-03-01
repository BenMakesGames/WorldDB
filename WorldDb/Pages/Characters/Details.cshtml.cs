using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Characters;

public class DetailsModel : PageModel
{
    private readonly CharacterService _characterService;

    public DetailsModel(CharacterService characterService)
    {
        _characterService = characterService;
    }

    public Character? Character { get; set; }

    public IActionResult OnGet(string slug)
    {
        Character = _characterService.GetBySlug(slug);
        if (Character is null)
            return NotFound();
        return Page();
    }
}
