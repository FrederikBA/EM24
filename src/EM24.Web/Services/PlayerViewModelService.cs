using EM24.Core.Interfaces.DomainServices;
using EM24.Web.Interfaces;
using EM24.Web.Models;

namespace EM24.Web.Services;

public class PlayerViewModelService : IPlayerViewModelService
{
    private readonly IPlayerService _playerService;

    public PlayerViewModelService(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    public async Task<List<PlayerViewModel>> GetPlayers()
    {
        var players = await _playerService.GetPlayers();
        
        return players.Select(player => new PlayerViewModel
        {
            Id = player.Id,
            Name = player.Name,
            Points = player.Points
        }).ToList();
    }
}