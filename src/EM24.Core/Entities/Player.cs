namespace EM24.Core.Entities;

public class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Points { get; set; }
    public List<PlayerGuess>? PlayerGuesses { get; set; } = new();
}