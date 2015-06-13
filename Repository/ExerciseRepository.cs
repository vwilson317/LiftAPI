using System;
using System.Collections.Generic;
using Domain;

namespace Repository
{
    public interface IExerciseRepository : IRepositoryBase<Exercise>
    {
        
    }

    public class ExerciseRepository : IExerciseRepository
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

        public Exercise Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
