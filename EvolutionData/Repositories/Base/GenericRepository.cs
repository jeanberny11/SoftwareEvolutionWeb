using EvolutionData.Context;
using EvolutionData.Entities.Base;
using Microsoft.EntityFrameworkCore;


namespace EvolutionData.Repositories.Base
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId> where TId : struct
    {
        private readonly EvolutionDbContext _dbCOntext;
        public GenericRepository(EvolutionDbContext dbCOntext)
        {
            _dbCOntext = dbCOntext;
        }

        public async Task Create(TEntity entity)
        {
            var res = await _dbCOntext.Set<TEntity>().AddAsync(entity);
            await _dbCOntext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbCOntext.Set<TEntity>().Remove(entity);
            await _dbCOntext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbCOntext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity?> GetById(TId id)
        {
            return await _dbCOntext.Set<TEntity>().FirstOrDefaultAsync(e => e.GetId().Equals(id));
        }

        public async Task Update(TEntity entity)
        {
            _dbCOntext.Set<TEntity>().Update(entity);
            await _dbCOntext.SaveChangesAsync();
        }
    }
}
