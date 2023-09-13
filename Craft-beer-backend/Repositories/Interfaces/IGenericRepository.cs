using System.Collections.Generic;

namespace Craft_beer_backend.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity FindById(long id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity item);
        void Delete(TEntity item);
        void Update(TEntity item);
    }
}
