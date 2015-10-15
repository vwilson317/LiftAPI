using System;
using APIModels;
using Domain;

namespace RepositoryService.Workout
{
    public interface IWorkoutMapper : IMapper<WorkoutRoutine, LogModel>
    {

    }

    public class WorkoutMapper : IWorkoutMapper
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
