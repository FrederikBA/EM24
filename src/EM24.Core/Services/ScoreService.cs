using EM24.Core.Entities;
using EM24.Core.Interfaces.DomainServices;
using EM24.Core.Interfaces.Repositories;
using EM24.Core.Specifications;

namespace EM24.Core.Services;

public class ScoreService : IScoreService
{
    private readonly IReadRepository<PlayerGuess> _playerGuessRepository;
    private readonly IPlayerService _playerService;
    private readonly IGameService _gameService;

    public ScoreService(IReadRepository<PlayerGuess> playerGuessRepository, IPlayerService playerService,
        IGameService gameService)
    {
        _playerGuessRepository = playerGuessRepository;
        _playerService = playerService;
        _gameService = gameService;
    }
    
    public async Task<int> GetPlayerScore(int playerId)
    {
        var playerGuesses = await _playerGuessRepository.ListAsync(new GetGuessesByPlayerIdSpec(playerId));

        var points = 0;

        foreach (var playerGuess in playerGuesses)
        {
            var game = await _gameService.GetGameById(playerGuess.GameId);

            if (game != null && game.Result != null)
            {
                if (playerGuess.Guess == game.Result)
                {
                    points++;
                }
            }
        }

        return points;
    }

}