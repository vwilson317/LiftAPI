using System;
using System.Collections.Generic;
using APIModels;
using Repository;
using RepositoryService.User;

namespace RepositoryService
{
    public interface IUserRepositoryService : IRepositoryBaseService<UserModel>
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

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
