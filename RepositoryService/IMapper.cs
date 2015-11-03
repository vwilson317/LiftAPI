using Domain;

namespace RepositoryService
{
    public interface IMapper<TEntity, TResource>
        where TEntity : Entity
        where TResource : class
    {
        TEntity Map(TResource resource);
        TResource Map(TEntity entity);
    }
}
