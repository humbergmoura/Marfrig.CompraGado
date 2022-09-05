using Domain.Abstractions;

namespace Infra.Base;

public interface IDatabaseRepository<TEntity> : IDisposable where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(dynamic id);
    IList<TEntity> GetAll(int PageNumber = -1, int PageSize = 10);
    Task<TEntity> SaveOrUpdateAsync(TEntity entity, Guid? currentUserId = null, bool saveAction = false, string action = null);
    Task<IEnumerable<TEntity>> SaveOrUpdateAsync(IEnumerable<TEntity> manyEntities, Guid? currentUserId = null, string action = null);
    void Delete(TEntity entity, string action = null);
    void Delete(IEnumerable<TEntity> manyEntities, string action = null);
}