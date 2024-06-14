using EM24.Core.Entities;

namespace EM24.Core.Interfaces.DomainServices;

public interface IPlayerService
{
    public Task<List<Player>> GetPlayers();
    public Task<Player> GetPlayerById(int id);
}