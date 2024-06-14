namespace EM24.Core.Interfaces.DomainServices;

public interface IScoreService
{
    public Task<int> GetPlayerScore(int playerId);
}