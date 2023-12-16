namespace Twenty_Crm_Application.Common.Interfaces.Repositories.Generic;

public interface IGenericRepository<TEntity>
where TEntity : class, IBaseEntity
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
    Task<TEntity> FindFirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression,
            string includeProperties = "");

    Task<TEntity> GetByIdAsync(Guid id);

    Task AddRangeAsync(IList<TEntity> entities);
    Task<TEntity> CreateAsync(TEntity entity, string userName);

    Task UpdateAsync(TEntity entity, string userName);
    Task UpdateRange(IList<TEntity> entities);
    Task<TEntity> AddAsync(TEntity entity);
    Task AddManyAsync(IList<TEntity> entities);
    Task<bool> DeleteAsync(Guid id, string userName);
    Task DeleteManyAsync(IList<TEntity> entities, string userId);
    Task<bool> SaveChangeAsync();
}
