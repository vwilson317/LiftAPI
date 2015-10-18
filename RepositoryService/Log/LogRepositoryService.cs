using System;
using System.Collections.Generic;
using APIModels;
using Repository;
using RepositoryService.Workout;

namespace RepositoryService.Log
{
    public interface ILogRepositoryService : IRepositoryBaseService<LogResource>
    {
        
    }

    public class LogRepositoryService : ILogRepositoryService
    {
        private ILogRepository _repo;
        private ILogMapper _mapper;

        public LogRepositoryService(ILogRepository repo, ILogMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<LogResource> GetAll()
        {
            throw new NotImplementedException();
        }

        public LogResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LogResource Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
