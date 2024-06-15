using EM24.Core.Interfaces.DomainServices;
using EM24.Core.Models;
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

        return games.Select(game => 
        {
            string result;
            if (game.Result == (Result?)1)
            {
                result = game.RightTeam!;
            }
            else if (game.Result == (Result?)2)
            {
                result = game.LeftTeam!;
            }
            else if (game.Result == 0)
            {
                result = "Uafgjort";
            }
            else
            {
                result = "Ikke spillet";
            }

            return new GameViewModel
            {
                Id = game.Id,
                RightTeam = game.RightTeam!,
                LeftTeam = game.LeftTeam!,
                Result = result
            };
        }).ToList();
    }

}