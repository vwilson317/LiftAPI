using System;
using Domain;
using Resources;

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

        public LogResource CreateResource(WorkoutRoutine entity)
        {
            throw new NotImplementedException();
        }
    }
}
