using Ardalis.Specification;

namespace EM24.Core.Interfaces.Repositories;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}