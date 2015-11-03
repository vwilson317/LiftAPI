using Domain;

namespace Repository
{
    public interface IExerciseRepository : IRepository<Exercise>
    {

    }
    public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
