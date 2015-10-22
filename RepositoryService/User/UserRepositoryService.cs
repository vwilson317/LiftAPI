using System;
using System.Linq;
using Repository;
using Resources;

namespace RepositoryService.User
{
    public interface IUserRepositoryService : IRepositoryBaseService<UserResource>
    {
        
    }

    public class UserRepositoryService : IUserRepositoryService
    {
        private IUserMapper _mapper;
        private IRepository<Domain.User, object> _repo;

        public UserRepositoryService(IRepository<Domain.User,object> repo, IUserMapper mapper)
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
            throw new NotImplementedException();
        }
    }
}
