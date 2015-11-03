using System;
using Resources;

namespace RepositoryService.User
{
    public interface IUserMapper : IMapper<Domain.User, UserResource>
    {

    }

    public class UserMapper : IUserMapper
    {
        public Domain.User Map(UserResource resource)
        {
            throw new NotImplementedException();
        }

        public UserResource Map(Domain.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
