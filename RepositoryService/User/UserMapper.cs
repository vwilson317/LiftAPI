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
            return new Domain.User
            {
                Id = resource.Id,
                Name = resource.Name
            };
        }

        public UserResource Map(Domain.User entity)
        {
            return new UserResource
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
