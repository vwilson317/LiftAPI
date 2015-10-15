using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryBase<T>
    {
        void Create();
        void Edit();
        void Delete();
        void Save();

        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
