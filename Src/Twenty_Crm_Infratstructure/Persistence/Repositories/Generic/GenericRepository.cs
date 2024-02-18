using System.Linq.Expressions;
using Twenty_Crm_Application.Common.Interfaces.Repositories.Generic;
using Twenty_Crm_Domain.Enums;

namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Generic;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
  where TEntity : BaseEntity
{
    private readonly IApplicationDbContext dbContext;

    public GenericRepository(IApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<TEntity> CreateAsync(TEntity entity, string userName)
    {
        entity.CreatedBy = userName;
        var result = await dbContext.SetDb<TEntity>().AddAsync(entity);
        entity.CreateDate = DateTime.Now;
        //entity.ModifyDate = DateTime.Now;
        await dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task UpdateAsync(TEntity entity, string userName)
    {
        //entity.ModifyDate = DateTime.Now;
        //entity.ModifiedBy = userName;
        dbContext.SetDb<TEntity>().Update(entity);
        await dbContext.SaveChangesAsync();
    }
    public IQueryable<TEntity> GetAll()
    {
        return dbContext.SetDb<TEntity>().Where(b => b.BaseStatus != BaseEntityStatus.Deleted).OrderByDescending(z => z.CreateDate).AsSplitQuery().AsNoTracking();
    }

    public IQueryable<TEntity> GetByCondition(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
    {
        IQueryable<TEntity> query = dbContext.SetDb<TEntity>().Where(a => a.BaseStatus != BaseEntityStatus.Deleted).AsNoTracking();


        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (orderBy != null)
        {
            query = orderBy(query);
        }

        return query;
    }
    public async Task<TEntity> FindFirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression,
            string includeProperties = "")
    {
        IQueryable<TEntity> query = dbContext.SetDb<TEntity>().Where(a => a.BaseStatus != BaseEntityStatus.Deleted);

        foreach (var includeProperty in includeProperties
            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        return await query.FirstOrDefaultAsync(expression);
    }
    public async Task<bool> DeleteAsync(Guid id, string userName)
    {
        try
        {
            var entity = await GetByIdAsync(id);
            if (entity is not null)
            {
                await this.CreateAsync(entity, userName);
                //entity.ModifiedBy = userName;
                //entity.BaseStatus = BaseEntityStatus.Deleted;
                //dbContext.SetDb<TEntity>().Remove(entity);
                //dbContext.SetDb<TEntity>().Update(entity);
                //await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await dbContext.SetDb<TEntity>().AsTracking()
                    .FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task AddRangeAsync(IList<TEntity> entities)
    {
        await dbContext.SetDb<TEntity>().AddRangeAsync(entities);
        await
            dbContext.SaveChangesAsync();
    }

    public async Task DeleteManyAsync(IList<TEntity> entities, string userId)
    {
        foreach (var item in entities)
        {
            //item.ModifyDate = DateTime.Now;
            //item.ModifiedBy = userId;
            item.BaseStatus = BaseEntityStatus.Deleted;
        }

        //dbContext.SetDb<TEntity>().RemoveRange(entities);
        dbContext.SetDb<TEntity>().UpdateRange(entities);
        await
         dbContext.SaveChangesAsync();
    }

    public async Task UpdateRange(IList<TEntity> entities)
    {
        dbContext.SetDb<TEntity>().UpdateRange(entities);
        await
         dbContext.SaveChangesAsync();
    }

    public async Task<bool> SaveChangeAsync()
    {
        return await
          dbContext.SaveChangesAsync() > 0;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var createdEntity = await this.dbContext.SetDb<TEntity>().AddAsync(entity);

        return createdEntity.Entity;
    }

    public async Task AddManyAsync(IList<TEntity> entities)
    {
        await this.dbContext.SetDb<TEntity>().AddRangeAsync(entities);
    }
}
