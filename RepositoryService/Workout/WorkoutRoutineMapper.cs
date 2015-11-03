using System;
using Domain;
using Resources;

namespace RepositoryService.Workout
{
    public interface IWorkoutRoutineMapper : IMapper<WorkoutRoutine, WorkoutRoutineResource>
    {

    }

    public class WorkoutRoutineMapper : IWorkoutRoutineMapper
    {
        public WorkoutRoutine Map(WorkoutRoutineResource resource)
        {
            throw new NotImplementedException();
        }

        public WorkoutRoutineResource Map(WorkoutRoutine entity)
        {
            throw new NotImplementedException();
        }
    }
}
