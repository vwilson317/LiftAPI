using System;
using Resources;

namespace RepositoryService.Log
{
    public interface ILogMapper : IMapper<Domain.Log, LogResource>
    {

    }

    public class LogMapper : ILogMapper
    {
        public Domain.Log CreateEntity(LogResource model)
        {
            throw new NotImplementedException();
        }

        public LogResource CreateResource(Domain.Log entity)
        {
            throw new NotImplementedException();
        }
    }
}
