using EM24.Core.Models;

namespace EM24.Core.Entities;

public class PlayerGuess
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public Player Player { get; set; }
    public int GameId { get; set; }
    public Game? Game { get; set; }
    public Result Guess { get; set; }
}