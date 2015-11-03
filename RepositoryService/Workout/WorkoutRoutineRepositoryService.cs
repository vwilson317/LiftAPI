using System;
using System.Linq;
using Domain;
using Repository;
using RepositoryService.Common;
using Resources;

namespace RepositoryService.Workout
{
    public class WorkoutRoutineRepositoryService :
        RepositoryService<IWorkoutRoutineRepository, WorkoutRoutine, WorkoutRoutineResource, IWorkoutRoutineMapper>,
        IWorkoutRoutineRepositoryService
    {
        public WorkoutRoutineRepositoryService(IWorkoutRoutineRepository repo, IWorkoutRoutineMapper routineMapper)
            : base(repo, routineMapper)
        {

        }

        public void Create(WorkoutRoutineResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkoutRoutineResource entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(WorkoutRoutineResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkoutRoutineResource entity)
        {
            throw new NotImplementedException();
        }

        WorkoutRoutineResource IRepositoryService<WorkoutRoutineResource>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<WorkoutRoutineResource> IRepositoryService<WorkoutRoutineResource>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}