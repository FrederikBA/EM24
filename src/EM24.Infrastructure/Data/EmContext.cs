using EM24.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EM24.Infrastructure.Data;

public class EmContext : DbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<PlayerGuess> PlayerGuesses { get; set; }
    
    public EmContext(DbContextOptions<EmContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Primary keys
        modelBuilder.Entity<Player>().HasKey(p => p.Id);
        modelBuilder.Entity<Game>().HasKey(g => g.Id);
        modelBuilder.Entity<PlayerGuess>().HasKey(pg => pg.Id);
        
        //Relationships
        
        // One-to-Many relationship between Game and PlayerGuess
        modelBuilder.Entity<PlayerGuess>()
            .HasOne(pg => pg.Game)
            .WithMany(g => g.PlayerGuesses)
            .HasForeignKey(pg => pg.GameId);
            
        // One-to-Many relationship between Player and PlayerGuess
        modelBuilder.Entity<PlayerGuess>()
            .HasOne(pg => pg.Player)
            .WithMany(p => p.PlayerGuesses)
            .HasForeignKey(pg => pg.PlayerId);
    }
}