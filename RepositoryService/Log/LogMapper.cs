using System;
using Resources;

namespace RepositoryService.Log
{
    public interface ILogMapper : IMapper<Domain.Log, LogResource>
    {

    }

    public class LogMapper : ILogMapper
    {
        public Domain.Log Map(LogResource resource)
        {
            throw new NotImplementedException();
        }

        public LogResource Map(Domain.Log entity)
        {
            throw new NotImplementedException();
        }
    }
}
