using Domain;

namespace Repository
{
    public interface IWorkoutRoutineRepository : IRepository<WorkoutRoutine>
    {
        
    }

    public class WorkoutRoutineRepository : Repository<WorkoutRoutine>, IWorkoutRoutineRepository
    {
        public WorkoutRoutineRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
