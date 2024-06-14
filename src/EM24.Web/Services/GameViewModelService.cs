using EM24.Core.Interfaces.DomainServices;
using EM24.Web.Interfaces;
using EM24.Web.Models;

namespace EM24.Web.Services;

public class GameViewModelService : IGameViewModelService
{
    private readonly IGameService _gameService;

    public GameViewModelService(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<List<GameViewModel>> GetGames()
    {
        var games = await _gameService.GetGames();
        
        return games.Select(game => new GameViewModel
        {
            Id = game.Id,
            RightTeam = game.RightTeam!,
            LeftTeam = game.LeftTeam!,
            Result = game.Result,
        }).ToList();
    }
}