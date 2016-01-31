using System.Collections.Generic;

namespace Abit.Data
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey id);
        void Save(TEntity item);
        void Delete(TKey id);
    }
}
