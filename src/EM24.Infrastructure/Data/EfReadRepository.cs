using Ardalis.Specification.EntityFrameworkCore;
using EM24.Core.Interfaces.Repositories;

namespace EM24.Infrastructure.Data;

public class EfReadRepository<T> : RepositoryBase<T>, IReadRepository<T> where T : class
{
    public readonly EmContext EmContext;
    
    public EfReadRepository(EmContext dbContext) : base(dbContext)
    {
        EmContext = dbContext;
    }
}