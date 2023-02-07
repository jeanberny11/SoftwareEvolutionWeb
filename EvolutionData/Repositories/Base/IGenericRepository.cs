using EvolutionData.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionData.Repositories.Base
{
    public interface IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId> where TId : struct
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity?> GetById(TId id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);
    }
}
