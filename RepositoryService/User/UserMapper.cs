using System;
using APIModels;
using Domain;

namespace RepositoryService.User
{
    public interface IUserMapper : IMapper<Domain.User, UserResource>
    {

    }

    public class UserMapper : IUserMapper
    {
        public Domain.User CreateEntity(UserResource model)
        {
            throw new NotImplementedException();
        }

        public UserResource CreateModel(Domain.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
