using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace RepositoryService.Common
{
    public abstract class RepositoryService<TRepository, TEntity, TResource , TMapper> :
    IRepositoryService<TResource>
        where TEntity : Entity
        where TRepository : IRepository<TEntity>
        where TResource : class
        where TMapper : IMapper<TEntity, TResource>
    {
        public TRepository Repository { get; set; }
        public TMapper Mapper { get; set; }
        protected RepositoryService(TRepository repository, TMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        public void Create(TResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(TResource entity)
        {
            throw new NotImplementedException();
        }

        public TResource Get(int id)
        {
            var entity = Repository.Get(id);
            var resource = Mapper.Map(entity);
            return resource;
        }

        public IQueryable<TResource> GetAll()
        {

            throw new NotImplementedException();
        }
    }
}
