using Ardalis.Specification;

namespace EM24.Core.Interfaces.Repositories;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
{
    
}