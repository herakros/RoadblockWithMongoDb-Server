using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Contracts.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity obj);

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
