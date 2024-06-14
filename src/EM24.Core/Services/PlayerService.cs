using EM24.Core.Entities;
using EM24.Core.Interfaces.DomainServices;
using EM24.Core.Interfaces.Repositories;

namespace EM24.Core.Services;

public class PlayerService : IPlayerService
{
    private IReadRepository<Player> _playerReadRepository;

    public PlayerService(IReadRepository<Player> playerReadRepository)
    {
        _playerReadRepository = playerReadRepository;
    }

    public async Task<List<Player>> GetPlayers()
    {
        var players = await _playerReadRepository.ListAsync();
        
        return players;
    }
}