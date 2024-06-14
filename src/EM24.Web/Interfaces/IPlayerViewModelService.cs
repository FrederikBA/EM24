using EM24.Web.Models;

namespace EM24.Web.Interfaces;

public interface IPlayerViewModelService
{
    public Task<List<PlayerViewModel>> GetPlayers();
}