using Domain;

namespace Repository
{
    public interface ILogRepository : IRepository<Log, object> { }

    public class LogRepository : NHibernateRepository<Log, object>
    {
      
    }
}
