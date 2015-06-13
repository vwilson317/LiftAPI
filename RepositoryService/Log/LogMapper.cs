using System;
using APIModels;
using Domain;

namespace RepositoryService.Workout
{
    public interface ILogMapper : IMapper<WorkoutRoutine, LogModel>
    {

    }

    public class LogMapper : ILogMapper
    {
        public WorkoutRoutine CreateEntity(LogModel model)
        {
            throw new NotImplementedException();
        }

        public LogModel CreateModel(WorkoutRoutine entity)
        {
            throw new NotImplementedException();
        }
    }
}
