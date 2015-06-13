using System.Collections.Generic;

namespace RepositoryService
{
    public interface IRepositoryBaseService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Delete(int id);
        T Update(int id);
    }
}
