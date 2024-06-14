using EM24.Web.Models;

namespace EM24.Web.Interfaces;

public interface IGameViewModelService
{
    public Task<List<GameViewModel>> GetGames();
}