using System;
using APIModels;
using Domain;

namespace RepositoryService.User
{
    public interface IUserMapper : IMapper<Domain.User, UserModel>
    {

    }

    public class UserMapper : IUserMapper
    {
        public Domain.User CreateEntity(UserModel model)
        {
            throw new NotImplementedException();
        }

        public UserModel CreateModel(Domain.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
