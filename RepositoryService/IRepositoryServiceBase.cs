using System.Linq;

namespace RepositoryService
{
    public interface IRepositoryBaseService<TEntity>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void SaveOrUpdate(TEntity entity);

        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
    }
}
