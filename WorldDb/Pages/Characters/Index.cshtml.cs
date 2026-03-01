using Microsoft.AspNetCore.Mvc.RazorPages;
using WorldDb.Models;
using WorldDb.Services;

namespace WorldDb.Pages.Characters;

public class IndexModel : PageModel
{
    private readonly CharacterService _characterService;

    public IndexModel(CharacterService characterService)
    {
        _characterService = characterService;
    }

    public List<Character> Characters { get; set; } = new();

    public void OnGet()
    {
        Characters = _characterService.GetAll();
    }
}
