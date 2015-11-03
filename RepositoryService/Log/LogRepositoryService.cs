using System;
using System.Linq;
using Repository;
using RepositoryService.Common;
using Resources;

namespace RepositoryService.Log
{
    public interface ILogRepositoryService : IRepositoryService<LogResource>
    {
        
    }

    public class LogRepositoryService : ILogRepositoryService
    {
        private IRepository<Domain.Log> _repo;
        private ILogMapper _mapper;

        public LogRepositoryService(IRepository<Domain.Log> repo, ILogMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Create(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public LogResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<LogResource> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
