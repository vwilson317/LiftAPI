using System;
using Resources;

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

        public UserResource CreateResource(Domain.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
