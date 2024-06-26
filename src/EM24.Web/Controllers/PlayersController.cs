using EM24.Core.Interfaces.DomainServices;
using EM24.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EM24.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IPlayerViewModelService _playerViewModelService;

    public PlayersController(IPlayerViewModelService playerViewModelService)
    {
        _playerViewModelService = playerViewModelService;
    }


    [HttpGet]
    public async Task<IActionResult> GetPlayers()
    {
        var players = await _playerViewModelService.GetPlayers();
        return Ok(players);
    }
}