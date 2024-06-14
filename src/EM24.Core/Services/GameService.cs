using EM24.Core.Entities;
using EM24.Core.Interfaces.DomainServices;
using EM24.Core.Interfaces.Repositories;

namespace EM24.Core.Services;

public class GameService : IGameService
{
    private readonly IReadRepository<Game> _gameReadRepository;

    public GameService(IReadRepository<Game> gameReadRepository)
    {
        _gameReadRepository = gameReadRepository;
    }

    public async Task<List<Game>> GetGames()
    {
        var games = await _gameReadRepository.ListAsync();
        return games;
    }
}