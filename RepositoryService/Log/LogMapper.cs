using System;
using APIModels;
using Domain;

namespace RepositoryService.Workout
{
    public interface ILogMapper : IMapper<WorkoutRoutine, LogResource>
    {

    }

    public class LogMapper : ILogMapper
    {
        public WorkoutRoutine CreateEntity(LogResource model)
        {
            throw new NotImplementedException();
        }

        public LogResource CreateModel(WorkoutRoutine entity)
        {
            throw new NotImplementedException();
        }
    }
}
