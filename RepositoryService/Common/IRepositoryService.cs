using System.Linq;

namespace RepositoryService.Common
{
    public interface IRepositoryService<TResource>
        where TResource : class
    {
        void Create(TResource entity);
        void Update(TResource entity);
        void Delete(TResource entity);
        void Delete(int id);
        void SaveOrUpdate(TResource entity);

        TResource Get(int id);
        IQueryable<TResource> GetAll();
    }
}
