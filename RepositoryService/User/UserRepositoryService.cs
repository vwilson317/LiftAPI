using System;
using System.Linq;
using Repository;
using RepositoryService.Common;
using Resources;

namespace RepositoryService.User
{
    public interface IUserRepositoryService : IRepositoryService<UserResource>
    {
        
    }

    public class UserRepositoryService : IUserRepositoryService
    {
        private IUserMapper _mapper;
        private IRepository<Domain.User> _repo;

        public UserRepositoryService(IRepository<Domain.User> repo, IUserMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Create(UserResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(UserResource entity)
        {
            throw new NotImplementedException();
        }

        public UserResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserResource> GetAll()
        {
            return _repo.GetAll().Select(_mapper.Map).AsQueryable();
        }
    }
}
