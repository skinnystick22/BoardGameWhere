using Ardalis.Specification;

namespace BoardGameWhere.SharedKernel.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
