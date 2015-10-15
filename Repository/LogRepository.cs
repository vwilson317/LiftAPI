using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public interface ILogRepository : IRepositoryBase<Log>
    {

    }

    public class LogRepository : ILogRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Log Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
