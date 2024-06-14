using Ardalis.Specification.EntityFrameworkCore;
using EM24.Core.Interfaces;
using EM24.Core.Interfaces.Repositories;

namespace EM24.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
{
    public readonly EmContext EmContext;
    
    public EfRepository(EmContext dbContext) : base(dbContext)
    {
        EmContext = dbContext;
    }
}