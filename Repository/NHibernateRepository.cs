using NHibernate;
using NHibernate.Linq;
using System.Linq;
using System.Transactions;
using Domain;
using LiftAPI;

namespace Repository
{
    public interface IRepository<TEntity, TId>
    {
        TId Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TId id);
        void SaveOrUpdate(TEntity entity);

        TEntity Get(TId id);
        IQueryable<TEntity> GetAll();
    }

    public abstract class NHibernateRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : Entity
        where TId : new()
    {
        /// <summary>
        /// NHibernate ISession to be used to manipulate data in the
        /// database.
        /// </summary>
        protected ISession CurrentSession { get; set; }

        protected NHibernateRepository()
        {
            SessionHelper sessionHelper = new SessionHelper();
            CurrentSession = sessionHelper.Current;
        }

        public TId Create(TEntity entity)
        {
            var id = new TId();
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                id = (TId)CurrentSession.Save(entity);
                transaction.Complete();
            }

            return id;
        }

        public TEntity Get(TId id)
        {
            TEntity entity = CurrentSession.Get<TEntity>(id);
            return entity;
        }

        /// <summary>
        /// Save or Update an Entity.
        /// </summary>
        /// <param name="entity">Entity to be saved or updated.</param>
        public void SaveOrUpdate(TEntity entity)
        {
            TId identifier = new TId();
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                CurrentSession.SaveOrUpdate(entity);
                transaction.Complete();
            }
        }

        /// <summary>
        /// Update an existing Entity.
        /// </summary>
        /// <param name="entity">Entity to be updated.</param>
        public void Update(TEntity entity)
        {
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                CurrentSession.Update(entity);
                CurrentSession.Flush();
                transaction.Complete();
            }
        }

        /// <summary>
        /// Delete an Entity based on its Instance.
        /// </summary>
        /// <param name="entity">Entity Instance.</param>
        public void Delete(TEntity entity)
        {
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                CurrentSession.Delete(entity);
                transaction.Complete();
            }
        }

        /// <summary>
        /// Delete an Entity based on its Identifier.
        /// </summary>
        /// <param name="entityIdentifier">Entity Identifier.</param>
        public void Delete(TId id)
        {
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                TEntity entity = Get(id);
                CurrentSession.Delete(entity);
                transaction.Complete();
            }
        }

        /// <summary>
        /// Retrieve all Entities from the database.
        /// </summary>
        /// <returns>List of all entities.</returns>
        public IQueryable<TEntity> GetAll()
        {
            return CurrentSession.Query<TEntity>();
        }
    }
}
