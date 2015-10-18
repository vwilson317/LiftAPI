using System;
using System.Collections.Generic;
using APIModels;
using Repository;
using RepositoryService.User;

namespace RepositoryService
{
    public interface IUserRepositoryService : IRepositoryBaseService<UserResource>
    {
        
    }

    public class UserRepositoryService : IUserRepositoryService
    {
        private IUserMapper _mapper;
        private IUserRepository _repo;

        public UserRepositoryService(IUserRepository repo, IUserMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<UserResource> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserResource Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
