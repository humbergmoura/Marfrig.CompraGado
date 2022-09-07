using Domain.Abstractions;
using Domain.Models;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infra.Base.Abstractions;

public abstract class DatabaseRepository<TEntity> : IDatabaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DbContext _context;
    protected readonly DbSet<TEntity> set;

    public DatabaseRepository(DbContext context)
    {
        this.set = context.Set<TEntity>();
        _context = context;
    }

    public async Task<TEntity> GetByIdAsync(dynamic id)
    {
        return await this.set.FindAsync(id);
    }

    public IList<TEntity> GetAll(int PageIndex = 1, int PageSize = 10)
    {
        return this.set.ToList();
    }

    public async Task<TEntity> Save(TEntity entity)
    {
        var added = await this.set.AddAsync(entity);
        await added.Context.SaveChangesAsync();
        return await this.GetByIdAsync(added.Entity.Id);
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        var updated = this.set.Update(entity);
        await updated.Context.SaveChangesAsync();
        return await this.GetByIdAsync(updated.Entity.Id);
    }

    public async Task<TEntity> SaveOrUpdateAsync(TEntity entity, Guid? currentUserId = null, bool saveAction = false, string action = null)
    {
        if (entity.Id > 0)
        {
            return await Update(entity);
        }
        else
        {
            return await Save(entity);
        }
    }

    public async Task<IEnumerable<TEntity>> SaveOrUpdateAsync(IEnumerable<TEntity> manyEntities, Guid? currentUserId = null, string action = null)
    {
        if (manyEntities.Any(c => c.Id > 0))
        {
            this.set.UpdateRange(manyEntities);
            return manyEntities;
        }

        await this.set.AddRangeAsync(manyEntities);
        return manyEntities;
    }

    public void Delete(TEntity entity, string action = null)
    {
        this.set.Remove(entity);
        _context.SaveChanges();
    }

    public void Delete(IEnumerable<TEntity> manyEntities, string action = null)
    {
        this.set.RemoveRange(manyEntities);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
