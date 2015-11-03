using Domain;

namespace Repository
{
    public interface ILogRepository : IRepository<Log> { }

    public class LogRepository : Repository<Log>
    {
        public LogRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
