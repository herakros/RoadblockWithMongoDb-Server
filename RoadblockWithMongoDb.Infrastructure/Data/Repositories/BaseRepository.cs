using MongoDB.Driver;
using RoadblockWithMongoDb.Contracts.Data;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _entity;

        public BaseRepository(IMongoDatabase database)
        {
            _entity = database.GetCollection<TEntity>($"{nameof(TEntity)}s");
        }

        public async Task AddAsync(TEntity obj)
        {
            await _entity.InsertOneAsync(obj);
        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            _ = await _entity.DeleteOneAsync(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entity.AsQueryable();
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var filter = Builders<TEntity>.Filter.Where(predicate);
            return (await _entity.FindAsync(filter)).FirstOrDefault();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            Expression<Func<TEntity, string>> func = f => f.Id;

            var value = (string)obj.GetType().GetProperty(func.Body.ToString().Split(".")[1]).GetValue(obj, null);
            var filter = Builders<TEntity>.Filter.Eq(func, value);

            if (obj != null)
                await _entity.ReplaceOneAsync(filter, obj);
        }
    }
}
