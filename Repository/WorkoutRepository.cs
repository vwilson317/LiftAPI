using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public interface IWorkoutRepository : IRepositoryBase<WorkoutRoutine>
    {
        
    }

    public class WorkoutRepository : IWorkoutRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public WorkoutRoutine Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkoutRoutine> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
