using System;
using System.Collections.Generic;
using APIModels;
using Repository;
using RepositoryService.Workout;

namespace RepositoryService.Log
{
    public interface ILogRepositoryService : IRepositoryBaseService<LogModel>
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

        public IEnumerable<LogModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public LogModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LogModel Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
