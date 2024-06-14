using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EM24.Infrastructure.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmContext>
{
    public EmContext CreateDbContext(string[] args)
    {
        const string connectionString = "Server=localhost;Database=EM24;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True";
        
        var optionsBuilder = new DbContextOptionsBuilder<EmContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new EmContext(optionsBuilder.Options);
    }
}