using EM24.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EM24.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly IGameViewModelService _gameViewModelService;

    public GamesController(IGameViewModelService gameViewModelService)
    {
        _gameViewModelService = gameViewModelService;
    }

    [HttpGet]
    public async Task<IActionResult> GetGames()
    {
        var games = await _gameViewModelService.GetGames();
        return Ok(games);
    }
}