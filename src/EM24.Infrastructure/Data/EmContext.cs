using Microsoft.EntityFrameworkCore;

namespace EM24.Infrastructure.Data;

public class EmContext : DbContext
{
    public EmContext(DbContextOptions<EmContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}