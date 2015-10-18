using System;
using APIModels;
using Domain;

namespace RepositoryService.Workout
{
    public interface IWorkoutMapper : IMapper<WorkoutRoutine, LogResource>
    {

    }

    public class WorkoutMapper : IWorkoutMapper
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
