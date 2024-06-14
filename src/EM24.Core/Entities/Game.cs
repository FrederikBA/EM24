using EM24.Core.Models;

namespace EM24.Core.Entities;

public class Game
{
    public int Id { get; set; }
    public string? RightTeam { get; set; }
    public string? LeftTeam { get; set; }
    public Result? Result { get; set; }
    public List<PlayerGuess>? PlayerGuesses { get; set; } = new();
}