using EM24.Core.Entities;

namespace EM24.Core.Interfaces.DomainServices;

public interface IGameService
{
    public Task<List<Game>> GetGames();
}