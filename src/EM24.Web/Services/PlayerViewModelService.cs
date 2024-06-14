using EM24.Core.Interfaces.DomainServices;
using EM24.Web.Interfaces;
using EM24.Web.Models;

namespace EM24.Web.Services;

public class PlayerViewModelService : IPlayerViewModelService
{
    private readonly IPlayerService _playerService;
    private readonly IScoreService _scoreService;

    public PlayerViewModelService(IPlayerService playerService, IScoreService scoreService)
    {
        _playerService = playerService;
        _scoreService = scoreService;
    }

    public async Task<List<PlayerViewModel>> GetPlayers()
    {
        var players = await _playerService.GetPlayers();
        
        return players.Select(player => new PlayerViewModel
        {
            Id = player.Id,
            Name = player.Name,
            Points = _scoreService.GetPlayerScore(player.Id).Result
        }).OrderByDescending(x => x.Points).ToList();
    }
}