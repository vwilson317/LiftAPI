using NHibernate;
using NHibernate.Linq;
using System.Linq;
using System.Transactions;
using Domain;
using NHibernateImp;

namespace Repository
{
    public interface IRepository<TEntity>
        where TEntity : class 
    {
        int Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void SaveOrUpdate(TEntity entity);

        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
    }

    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private UnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        protected ISession Session => _unitOfWork.Session;

        public int Create(TEntity entity)
        {
            var id = (int)Session.Save(entity);

            return id;
        }

        public TEntity Get(int id)
        {
            TEntity entity = Session.Get<TEntity>(id);
            return entity;
        }

        /// <summary>
        /// Save or Update an Entity.
        /// </summary>
        /// <param name="entity">Entity to be saved or updated.</param>
        public void SaveOrUpdate(TEntity entity)
        {
            Session.SaveOrUpdate(entity);
        }

        /// <summary>
        /// Update an existing Entity.
        /// </summary>
        /// <param name="entity">Entity to be updated.</param>
        public void Update(TEntity entity)
        {
            Session.Update(entity);
            Session.Flush();
        }

        /// <summary>
        /// Delete an Entity based on its Instance.
        /// </summary>
        /// <param name="entity">Entity Instance.</param>
        public void Delete(TEntity entity)
        {
            Session.Delete(entity);
        }

        /// <summary>
        /// Delete an Entity based on its Identifier.
        /// </summary>
        /// <param name="entityIdentifier">Entity Identifier.</param>
        public void Delete(int id)
        {
            TEntity entity = Get(id);
            Session.Delete(entity);
        }

        /// <summary>
        /// Retrieve all Entities from the database.
        /// </summary>
        /// <returns>List of all entities.</returns>
        public IQueryable<TEntity> GetAll()
        {
            var result = Session.QueryOver<TEntity>().List().AsQueryable();
            return result;
        }
    }
}
